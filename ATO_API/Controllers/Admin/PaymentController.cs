using ATO_API.Helper;
using AutoMapper;
using Azure;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Nest;
using Service.AccountSer;
using Service.OrderSer;
using Service.PageResult;
using Service.UserSupportSer;

namespace ATO_API.Controllers.Admin
{
    [Route("api/admin/payment-history")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class PaymentController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        public PaymentController(
            IOrderService orderService,
            IMapper mapper
            )
        {
            _orderService = orderService;
            _mapper = mapper;
        }
        [HttpGet("list-history-payment")]
        [ProducesResponseType(typeof(List<VNPayPaymentResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListUserSupport()
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
}
