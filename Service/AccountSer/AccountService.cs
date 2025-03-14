using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Nest;
using Service.EmailSer;
using Service.Repository;
using Service.TourCompanySer;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.AccountSer
{
    public class AccountService : IAccountService
    {
        private readonly Service.Repository.IRepository<Account> _accountRepository;
        private readonly Service.Repository.IRepository<TourCompany> _tourCompanyRepository;
        private readonly Service.Repository.IRepository<TouristFacility> _touristFacilityRepository;
        private readonly UserManager<Account> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        private readonly IMemoryCache _cache;
        private readonly TimeSpan _otpLifetime = TimeSpan.FromMinutes(5);
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        public AccountService(
            Service.Repository.IRepository<Account> accountRepository,
            Service.Repository.IRepository<TourCompany> tourCompanyRepository,
            Service.Repository.IRepository<TouristFacility> touristFacilityRepository,
        UserManager<Account> userManager,
            IConfiguration configuration,
            IEmailService emailService,
            IMemoryCache cache,
            RoleManager<IdentityRole<Guid>> roleManager
            )
        {
            _accountRepository = accountRepository;
            _userManager = userManager;
            _configuration = configuration;
            _emailService = emailService;
            _cache = cache;
            _tourCompanyRepository = tourCompanyRepository;
            _roleManager = roleManager;
            _touristFacilityRepository = touristFacilityRepository;
        }
        public async Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            return await _accountRepository.GetAllAsync();
        }
        public async Task<IEnumerable<Account>> GetAccountsAsync()
        {
            try
            {

                return await _accountRepository.Query()
                       .Include(b => b.TourCompany)
                       .Include(b => b.TouristFacility)
                       .ToListAsync();
            }
            catch (Exception)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<Account> GetAccountByIdAsync(Guid id)
        {

            try
            {

                return await _accountRepository.Query()
                       .Include(b => b.TourCompany)
                       .Include(b => b.TouristFacility)
                       .FirstOrDefaultAsync(a => a.Id == id);
            }
            catch (Exception)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task AddAccountAsync(Account account)

        {
            await _accountRepository.AddAsync(account);
        }

        public async Task UpdateAccountAsync(Account account)
        {
            await _accountRepository.UpdateAsync(account);
        }
        // hàm đăng nhập
        public async Task<ResponseLogin> LoginAsync(LoginDTO model)
        {
            if (string.IsNullOrWhiteSpace(model.Username) || string.IsNullOrWhiteSpace(model.Password))
            {
                return new ResponseLogin { ErrorMessage = "Tên đăng nhập và mật khẩu không được để trống!" };
            }

            var user = await _userManager.Users
                .SingleOrDefaultAsync(u => u.UserName == model.Username);

            if (user == null)
            {
                return new ResponseLogin { ErrorMessage = "Tài khoản không tồn tại!" };
            }

            if (!user.isAccountActive)
            {
                return new ResponseLogin { ErrorMessage = "Tài khoản của bạn đã bị khóa!" };
            }

            if (!await _userManager.CheckPasswordAsync(user, model.Password))
            {
                return new ResponseLogin { ErrorMessage = "Sai mật khẩu đăng nhập!" };
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            var role = userRoles.FirstOrDefault();

            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Fullname ?? ""),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

            foreach (var userRole in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            if (!string.IsNullOrEmpty(user.AvatarURL))
            {
                authClaims.Add(new Claim("AvatarUrl", user.AvatarURL));
            }

            var token = GenerateToken(authClaims);

            return new ResponseLogin
            {
                Bear = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = token.ValidTo,
                Role = role
            };
        }

        //hàm gen token

        private JwtSecurityToken GenerateToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var expirationTimeUtc = DateTime.UtcNow.AddHours(72);

            return new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.SpecifyKind(expirationTimeUtc, DateTimeKind.Utc),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );
        }
        // hàm gửi mã xác thực tài khoản để thay đổi mật khẩu
        public async Task<ResponseVM_Email> ForgotPasswordSendOTPAsync(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
            {
                return new ResponseVM_Email()
                {
                    Message = "Không tìm thấy tài khoản người dùng nào trùng với tên đăng nhập " + username + "!",
                    Status = false
                };
            }
            var otp = new Random().Next(100000, 999999).ToString();
            EmailRequest emailRequest = new EmailRequest();
            emailRequest.ToEmail = user.Email;
            emailRequest.Subject = "Mã Xác thực tài khoản người dùng";
            emailRequest.Body = $"Mã xác thực tài khoản của bạn là: {otp}";
            _cache.Set(emailRequest.ToEmail, otp, _otpLifetime);
            await _emailService.SendEmailAsync(emailRequest);

            return new ResponseVM_Email()
            {
                Message = "Mã xác thực đã được gửi đến email của bạn!",
                Status = true,
                toEmail = user.Email,
            };
        }
        // thay đổi mật khẩu khi đã xác thực thành công 
        public async Task<ResponseVM> ForgotPasswordAsync(ForgotPassword_DTO model)
        {
            var user = await _userManager.FindByNameAsync(model.username);
            if (user == null)
            {
                return new ResponseVM
                {
                    Status = false,
                    Message = "Không tìm thấy tài khoản!"
                };
            }
            else if (!model.NewPassword.Equals(model.ConfimPassword))
            {
                return new ResponseVM
                {
                    Status = false,
                    Message = "Mã xác nhận không chính xác!"
                };
            }
            else if (!IsValidPassword(model.NewPassword))
            {
                return new ResponseVM
                {
                    Status = false,
                    Message = "Mật khẩu mới phải chứa ít nhất một ký tự in hoa, một ký tự thường, một số và một ký tự đặc biệt."
                };
            }

            var resetPasswordResult = await _userManager.RemovePasswordAsync(user);
            if (!resetPasswordResult.Succeeded)
            {
                return new ResponseVM
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi, vui lòng thử lại sau!"
                };
            }
            var result = await _userManager.AddPasswordAsync(user, model.NewPassword);
            if (!result.Succeeded)
            {
                return new ResponseVM
                {
                    Status = false,
                    Message = "Đặt lại mật khẩu không thành công!"
                };
            }
            return new ResponseVM
            {
                Status = true,
                Message = "Đổi mật khẩu thành công!"
            };
        }
        // Phương thức kiểm tra mật khẩu mới
        private bool IsValidPassword(string password)
        {
            // Kiểm tra mật khẩu có ít nhất 1 ký tự in hoa, 1 ký tự thường, 1 số và 1 ký tự đặc biệt, 8 ký tự
            var passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");

            return passwordRegex.IsMatch(password);
        }

        public async Task<bool> ResetPasswordAsync(Guid id, string newPassword)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                return false;

            var removePasswordResult = await _userManager.RemovePasswordAsync(user);
            if (!removePasswordResult.Succeeded)
                return false;

            var addPasswordResult = await _userManager.AddPasswordAsync(user, newPassword);
            return addPasswordResult.Succeeded;
        }

        public async Task<bool> InactiveAccountAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                return false;

            user.isAccountActive = false;
            var updateResult = await _userManager.UpdateAsync(user);
            return updateResult.Succeeded;
        }
        public async Task<Account?> GetAccountByPhoneNumberAsync(string phoneNumber)
        {
            return await _accountRepository.Query()
                   .FirstOrDefaultAsync(a => a.PhoneNumber == phoneNumber);
        }

        public async Task<IEnumerable<Account>> GetUnassignedTourCompaniesAsync()
        {
            var role = await _roleManager.FindByIdAsync("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A");
            if (role == null)
            {
                return Enumerable.Empty<Account>();
            }

            var tourCompanyUsers = await _userManager.GetUsersInRoleAsync(role.Name);

            // Lấy danh sách UserId đã được gán trong bảng TourCompany
            var assignedUserIds = await _tourCompanyRepository.Query()
                                        .Select(tc => tc.UserId)
                                        .ToListAsync();

            // Lọc ra các user chưa được gán (UserId không nằm trong danh sách assignedUserIds)
            return tourCompanyUsers.Where(u => !assignedUserIds.Contains(u.Id));
        }

        public async Task<IEnumerable<Account>> GetUnassignedTouristFacilitiesAsync()
        {
            var role = await _roleManager.FindByIdAsync("49E15EF3-2D88-4812-955F-D00859B3F7E3");
            if (role == null)
            {
                return Enumerable.Empty<Account>();
            }

            var touristFacilityUsers = await _userManager.GetUsersInRoleAsync(role.Name);

            var assignedUserIds = await _touristFacilityRepository.Query()
                                        .Select(tc => tc.UserId)
                                        .ToListAsync();

            return touristFacilityUsers.Where(u => !assignedUserIds.Contains(u.Id));
        }
    }
}
