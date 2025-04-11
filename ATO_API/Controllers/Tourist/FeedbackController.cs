using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.FeedbackSer;
using Service.OrderSer;
using Service.ShippingSer;
using Service.VnPaySer;
using StackExchange.Redis;

namespace ATO_API.Controllers.Tourist
{
    [Route("api/tourist/feedback")]
    [ApiController]
    [Authorize(Roles = "Tourists")]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;
        private readonly IMapper _mapper;
        public FeedbackController(
            IMapper mapper,
            IFeedbackService feedbackService
           )
        {
            _mapper = mapper;
            _feedbackService = feedbackService;
        }
        [HttpGet("get-list-feedbacks/{ProductId}")]
        [ProducesResponseType(typeof(List<FeedbackRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFeedBacksByProductId(Guid ProductId)
        {
            try
            {
                var response = await _feedbackService.GetListFeedbacks_Product(ProductId);
                var responseResult = _mapper.Map<List<FeedbackRespone>>(response);


                return Ok(responseResult);
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
        [HttpGet("get-list-feedbacks/{TourId}")]
        [ProducesResponseType(typeof(List<FeedbackRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFeedBacksByTourId(Guid TourId)
        {
            try
            {
                var response = await _feedbackService.GetListFeedbacks_Tour(TourId);
                var responseResult = _mapper.Map<List<FeedbackRespone>>(response);


                return Ok(responseResult);
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
        [HttpGet("get-feedback/{FeedbackId}")]
        [ProducesResponseType(typeof(FeedbackRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFeedBackById(Guid FeedbackId)
        {
            try
            {
                var response = await _feedbackService.GetFeedbackDetails(FeedbackId);
                var responseResult = _mapper.Map<FeedbackRespone>(response);
                return Ok(responseResult);
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
        [HttpPost("create-feeback")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateFeedback([FromBody] FeedbackRequest FeedbackRequest)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                Feedback responseResult = _mapper.Map<Feedback>(FeedbackRequest);
                responseResult.UserId = Guid.Parse(userId);
                bool result = await _feedbackService.AddFeedBack(responseResult);
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Tạo mới thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Tạo mới sản phẩm không thành công!",
                });
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
