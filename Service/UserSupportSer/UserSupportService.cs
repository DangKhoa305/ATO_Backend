using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.PageResult;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.UserSupportSer
{
    public class UserSupportService : IUserSupportService
    {

        private readonly IRepository<UserSupport> _userSupportRepository;
        public UserSupportService(IRepository<UserSupport> userSupportRepository
        )
        {
            _userSupportRepository = userSupportRepository;
        }

        public async Task<PagedResult<UserSupport>> ListUserSupport(string? search, bool? IsResolved, IssueType? issueType, int page, int pageSize)
        {
            try
            {
                var query = _userSupportRepository.Query()
                                .Include(b => b.ResponeAccount);

                if (!string.IsNullOrEmpty(search))
                {
                    string searchConvert = search.ToLower();
                    query = (Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<UserSupport, Account?>)query.Where(b =>
                        b.Fullname.ToLower().Contains(searchConvert) ||
                        b.Email.ToLower().Contains(searchConvert) ||
                        b.ResponseMessage.ToLower().Contains(searchConvert) ||
                        b.SupportMessage.ToLower().Contains(searchConvert)
                    );
                }

                if (issueType.HasValue)
                {
                    query = (Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<UserSupport, Account?>)query.Where(b => b.IssueType == issueType);
                }

                int totalItems = await query.CountAsync();

                var UserSupports = await query
                    .OrderByDescending(b => b.RequestDate)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                return new PagedResult<UserSupport>
                {
                    Items = UserSupports,
                    TotalItems = totalItems,
                    CurrentPage = page,
                    PageSize = pageSize,
                    TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize)
                };
            }
            catch (Exception)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public Task<List<UserSupport>> ListUserSupport()
        {
            try
            {
                var query = _userSupportRepository.Query()
                                .Include(b => b.ResponeAccount).ToListAsync();
                return query;
            }
            catch (Exception)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<ResponseVM> ReplyRequestUserSupport(ReplyUserSupportRequest userSupport)
        {
            try
            {
                var usersp = await _userSupportRepository.GetByIdAsync(userSupport.SupportId);
                if (usersp == null)
                {
                    return new ResponseVM
                    {
                        Status = false,
                        Message = "Không tìm thấy yêu cầu của người dùng!"
                    };
                }
                usersp.ResponseMessage = userSupport.ResponseMessage;
                usersp.ResponeBy = userSupport.ResponeBy;
                usersp.ResponseDate = userSupport.ResponseDate;
                usersp.ResponseMessage = userSupport.ResponseMessage;
                usersp.IsResolved = true;
                usersp.UpdatedDate = DateTime.UtcNow;
                await _userSupportRepository.UpdateAsync(usersp);
                return new ResponseVM
                {
                    Status = true,
                    Message = "Cập nhật thành công!"
                };
            }
            catch (Exception)
            {
                return new ResponseVM
                {
                    Status = false,
                    Message = "Đã sảy ra lỗi. Vui lòng thử lại sau!"
                };
            }
        }

        public async Task<ResponseVM> RequestUserSupport(UserSupport userSupport)
        {
            try
            {
                userSupport.SupportId = Guid.NewGuid();

                await _userSupportRepository.AddAsync(userSupport);
                return new ResponseVM
                {
                    Status = true,
                    Message = "Gửi yêu cầu thành công!"
                };
            }
            catch (Exception)
            {
                return new ResponseVM
                {
                    Status = false,
                    Message = "Đã sảy ra lỗi. Vui lòng thử lại sau!"
                };
            }

        }

        public async Task<UserSupport> UserSupportDetails(Guid SupportId)
        {
            try
            {
                var usersp = await _userSupportRepository.Query()
                    .Include(us => us.ResponeAccount)
                    .FirstOrDefaultAsync(us => us.SupportId == SupportId);

                return usersp;
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!", ex);
            }
        }

    }
}
