using Data.DTO.Respone;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.WithdrawalSer;
using System.Linq;

namespace ATO_API.Controllers.Admin;

[Route("api/admin/withdrawals")]
[ApiController]
[Authorize(Roles = "Admin")]
public class WithdrawalController(IWithdrawalService withdrawalService) : ControllerBase
{
    private readonly IWithdrawalService _withdrawalService = withdrawalService;

    [HttpGet("generate-monthly")]
    public async Task<IActionResult> GenerateMonthlyWithdrawals()
    {
        try
        {
            var result = await _withdrawalService.GenerateMonthlyWithdrawals();
            if (!result)
                return Ok(new ResponseModel(false, "Đã tạo yêu cầu giải ngân cho tháng này"));

            return Ok(new ResponseModel(true, "Tạo yêu cầu giải ngân thành công"));
        }
        catch (Exception ex)
        {
            return Ok(new ResponseModel(false, ex.Message));
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        try
        {
            var result = await _withdrawalService.GetWithdrawalHistory_Admin();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return Ok(new ResponseModel(false, ex.Message));
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        try
        {
            var result = await _withdrawalService.GetWithdrawalHistory(id);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return Ok(new ResponseModel(false, ex.Message));
        }
    }

    [HttpPut("complete/{id}")]
    public async Task<IActionResult> CompleteWithdrawal(Guid id, [FromBody] UpdateWithdrawalRequest request)
    {
        try
        {
            var result = await _withdrawalService.CompleteWithdrawal(id, request.Note, string.Join(",", request.TransactionImgs));
            if (!result)
                return Ok(new ResponseModel(false, "Cập nhật lịch sử giải ngân thất bại"));

            return Ok(new ResponseModel(true, "Cập nhật lịch sử giải ngân thành công"));
        }
        catch (Exception ex)
        {
            return Ok(new ResponseModel(false, ex.Message));
        }
    }

    [HttpPut("cancel/{id}")]
    public async Task<IActionResult> CancelWithdrawal(Guid id, [FromBody] UpdateWithdrawalRequest request)
    {
        try
        {
            var result = await _withdrawalService.CancelWithdrawal(id, request.Note);
            if (!result)
                return Ok(new ResponseModel(false, "Cập nhật lịch sử giải ngân thất bại"));

            return Ok(new ResponseModel(true, "Cập nhật lịch sử giải ngân thành công"));
        }
        catch (Exception ex)
        {
            return Ok(new ResponseModel(false, ex.Message));
        }
    }
}

public class UpdateWithdrawalRequest
{
    public decimal Amount { get; set; }
    public string[] TransactionImgs { get; set; } = [];
    public string Note { get; set; }
}