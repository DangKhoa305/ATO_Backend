using Data.DTO.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.BankAccountSer;

namespace ATO_API.Controllers;

[Route("api/bank-accounts")]
[ApiController]
[Authorize]
public class BankAccountController(IBankAccountService bankAccountService) : ControllerBase
{
    private readonly IBankAccountService _bankAccountService = bankAccountService;

    [HttpPost]
    public async Task<IActionResult> CreateBankAccount([FromBody] BankAccountRequest request)
    {
        try
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var ownerId = await _bankAccountService.GetOwnerId(Guid.Parse(userId!));

            if (ownerId is null) return Ok(new { status = false, message = "Không tìm thấy tài khoản" });

            var response = await _bankAccountService.CreateBankAccount(request, ownerId);
            return Ok(new { status = true, message = "Không tìm thấy tài khoản" });
        }
        catch (Exception ex)
        {
            return Ok(new { status = true, message = ex.Message });
        }
    }

    [HttpPut("{bankAccountId}")]
    public async Task<IActionResult> UpdateBankAccount(Guid bankAccountId, [FromBody] BankAccountRequest request)
    {
        var response = await _bankAccountService.UpdateBankAccount(bankAccountId, request);
        return Ok(response);
    }

    [HttpDelete("{bankAccountId}")]
    public async Task<IActionResult> DeleteBankAccount(Guid bankAccountId)
    {
        var result = await _bankAccountService.DeleteBankAccount(bankAccountId);
        return Ok(result);
    }

    [HttpGet("owner/{ownerId}")]
    public async Task<IActionResult> GetBankAccountsByOwner(Guid ownerId)
    {
        var response = await _bankAccountService.GetBankAccountsByOwner(ownerId);
        return Ok(response);
    }

    [HttpGet("user")]
    public async Task<IActionResult> GetBankAccountsByOwner()
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        var response = await _bankAccountService.GetBankAccountsByUser(Guid.Parse(userId!));
        return Ok(response);
    }

    [HttpGet("{bankAccountId}")]
    public async Task<IActionResult> GetBankAccount(Guid bankAccountId)
    {
        var response = await _bankAccountService.GetBankAccount(bankAccountId);
        return Ok(response);
    }

    [HttpPatch("{bankAccountId}/set-primary")]
    public async Task<IActionResult> SetPrimaryAccount(Guid bankAccountId)
    {
        var result = await _bankAccountService.SetPrimaryAccount(bankAccountId);
        return Ok(result);
    }
}