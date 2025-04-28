using AutoMapper;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.OrderSer;

namespace ATO_API.Controllers.Admin;

[Route("api/admin/payment-history")]
[ApiController]
[Authorize(Roles = "Admin")]
public class PaymentController(
    IOrderService orderService,
    IMapper mapper) : ControllerBase
{
    private readonly IOrderService _orderService = orderService;
    private readonly IMapper _mapper = mapper;

    [HttpGet]
    [ProducesResponseType(typeof(List<VNPayPaymentResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAllAsync()
    {
        try
        {
            List<VNPayPaymentResponse> response = await _orderService.ListHistoryPayments();
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message,
            });
        }
    }
}
