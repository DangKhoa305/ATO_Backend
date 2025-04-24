using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.WithdrawalSer;

namespace ATO_API.Controllers;

[Route("api/withdrawl")]
[ApiController]
[Authorize]
public class WithdrawalController(IWithdrawalService withdrawalService) : ControllerBase
{
    [HttpGet("my-requests")]
    public async Task<IActionResult> GetMyWithdrawalRequests()
    {
        var userId = Guid.Parse(User.Identity?.Name!);
        var requests = await withdrawalService.GetUserWithdrawalRequests(userId);
        return Ok(requests);
    }

    [HttpGet("my-history")]
    public async Task<IActionResult> GetMyWithdrawalHistory()
    {
        var userId = Guid.Parse(User.Identity?.Name!);
        var history = await withdrawalService.GetUserWithdrawalHistory(userId);
        return Ok(history);
    }

    [HttpPost("request")]
    public async Task<IActionResult> CreateWithdrawalRequest([FromBody] WithdrawalRequest request)
    {
        request.UserId = Guid.Parse(User.Identity?.Name!);
        var result = await withdrawalService.CreateWithdrawalRequest(request);
        if (!result) return BadRequest();
        return Ok();
    }

    [HttpGet("pending")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetPendingRequests()
    {
        var requests = await withdrawalService.GetAllPendingRequests();
        return Ok(requests);
    }
    // lịch sử giải ngân của admin 
    [HttpGet("history")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetHistoryRequests()
    {
        var requests = await withdrawalService.GetWithdrawalHistory_Admin();
        return Ok(requests);
    }

    [HttpPut("{requestId}/process")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> ProcessRequest(
        Guid requestId,
        [FromQuery] bool isApproved,
        [FromBody] string adminResponse)
    {
        var adminId = Guid.Parse(User.Identity?.Name!);
        var result = await withdrawalService.ProcessWithdrawalRequest(requestId, isApproved, adminResponse, adminId);
        if (!result) return BadRequest();
        return Ok();
    }

    [HttpPut("{requestId}/complete")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> CompleteWithdrawal(
        Guid requestId,
        [FromBody] string transactionReference)
    {
        var result = await withdrawalService.CompleteWithdrawal(requestId, transactionReference);
        if (!result) return BadRequest();
        return Ok();
    }
}