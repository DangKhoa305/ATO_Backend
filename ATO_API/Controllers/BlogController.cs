﻿using ATO_API.Helper;
using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Service.BlogSer;
using Service.PageResult;

namespace ATO_API.Controllers
{
    [Route("api/blog")]
    [ApiController]
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
        [ProducesResponseType(typeof(List<Blog_Guest_DTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetBlogs()
        {
            try
            {
                var response = await _blogService.GetListBlogs();
                List<Blog_Guest_DTO> responseResult = _mapper.Map<List<Blog_Guest_DTO>>(response);
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
        [ProducesResponseType(typeof(Blog_Guest_DTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetBlogDetails(
            Guid blogId
        )
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
                Blog_Guest_DTO responseResult = _mapper.Map<Blog_Guest_DTO>(response);
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
    }
}
