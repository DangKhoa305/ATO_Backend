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
using Service.BlogSer;
using Service.PageResult;

namespace ATO_API.Controllers.ContentModerators
{
    [Route("api/blog/content-moderators")]
    [ApiController]
    [Authorize(Roles = "ContentModerators")]

    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public BlogController(
            IBlogService blogService,
            IMapper mapper
        )
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        [HttpPut("update-reply/{blogId}")]
        public async Task<IActionResult> UpdateReplyRequest(Guid blogId, [FromBody] UpdateReplyRequestDto request)
        {
            try
            {
                await _blogService.UpdateStatusAsync(blogId, request.NewStatus, request.ReplyContent);
                return Ok(new { Status = true, Message = "Phản hồi thành công!" });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { Status = false, Message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã xảy ra lỗi vui lòng thử lại sau!" });
            }
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateBlog([FromBody] BlogCreateRequest model)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId)) return Unauthorized("Không tìm thấy ID người dùng!");
                var responseResult = _mapper.Map<Blog>(model);
                responseResult.CreateBy = Guid.Parse(userId);
                var createdBlog = await _blogService.CreateBlogAsync(responseResult);
                return Ok(new ResponseVM { Status = true, Message = "Tạo mới thành công!" });
            }
            catch (Exception)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã xảy ra lỗi vui lòng thử lại sau!" });
            }
        }
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateBlog(Guid id, [FromBody] BlogUpdateRequest model)
        {
            try
            {
                var responseResult = _mapper.Map<Blog>(model);
                bool updated = await _blogService.UpdateBlogAsync(id, responseResult);
                if (!updated)
                {
                    return NotFound(new ResponseVM { Status = false, Message = "Không tìm thấy bài viết!" });
                }

                return Ok(new ResponseVM { Status = true, Message = "Cập nhật thành công!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã xảy ra lỗi vui lòng thử lại sau!" });
            }
        }

    }
}