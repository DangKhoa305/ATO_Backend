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
    [Route("api/content-moderators/blog")]
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
        [HttpGet("get-blogs")]
        [ProducesResponseType(typeof(List<Blog_CM_DTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBlogs()
        {
            try
            {
                var response = await _blogService.GetListBlogs_CM();
                List<Blog_CM_DTO> responseResult = _mapper.Map<List<Blog_CM_DTO>>(response);
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

        [HttpGet("get-blog-details/{blogId}")]
        [ProducesResponseType(typeof(Blog_CM_DTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBlogDetails(Guid blogId)
        {
            try
            {
                var response = await _blogService.GetBlogDetails(blogId);
                if (response == null)
                {
                    return StatusCode(400, new ResponseVM
                    {
                        Status = false,
                        Message = "Không tìm thấy bài viết",
                    });
                }
                Blog_CM_DTO responseResult = _mapper.Map<Blog_CM_DTO>(response);
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
        [HttpPut("update-reply/{blogId}")]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
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
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
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
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
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
            catch (Exception)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã xảy ra lỗi vui lòng thử lại sau!" });
            }
        }

    }
}
