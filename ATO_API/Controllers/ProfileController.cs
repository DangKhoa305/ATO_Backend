using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.DTO.Response;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;

namespace ATO_API.Controllers;

[Route("api/profile")]
[ApiController]
[Authorize]
public class ProfileController(IAccountService accountService, IMapper mapper) : ControllerBase
{
    private readonly IAccountService _accountService = accountService;
    private readonly IMapper _mapper = mapper;

    [HttpGet]
    [ProducesResponseType(typeof(ProfileResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetProfile()
    {
        try
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var user = await _accountService.GetAccountByIdAsync(Guid.Parse(userId!));

            if (user == null)
                return NotFound(new ResponseVM { Status = false, Message = "User not found" });

            var response = _mapper.Map<ProfileResponse>(user);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message
            });
        }
    }

    [HttpPut]
    [ProducesResponseType(typeof(ProfileResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateProfile([FromBody] UpdateProfileRequest request)
    {
        try
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var user = await _accountService.GetAccountByIdAsync(Guid.Parse(userId!));

            if (user == null)
                return NotFound(new ResponseVM { Status = false, Message = "User not found" });

            // Update user properties
            user.Fullname = request.FullName;
            user.PhoneNumber = request.PhoneNumber;
            user.Dob = request.DateOfBirth;
            user.AvatarURL = request.Avatar;

            await _accountService.UpdateAccountAsync(user);

            var response = _mapper.Map<ProfileResponse>(user);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message
            });
        }
    }


}