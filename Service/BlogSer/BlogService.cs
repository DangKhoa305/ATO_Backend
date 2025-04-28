using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Nest;
using Service.BlogSer;
using Service.EmailSer;
using Service.PageResult;
using Service.Repository;
using Service.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Service.BlogSer
{
    public class BlogService : IBlogService
    {
        private readonly Service.Repository.IRepository<Blog> _blogRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public BlogService(Service.Repository.IRepository<Blog> blogRepository, IHttpContextAccessor httpContextAccessor)
        {
            _blogRepository = blogRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Blog> GetBlogDetails(Guid BlogId)
        {
            try
            {
                var blog = await _blogRepository.Query()
                        .Include(b => b.Account)
                            .ThenInclude(a => a.TourCompany)
                        .Include(b => b.Account)
                            .ThenInclude(a => a.TouristFacility)
                        .SingleOrDefaultAsync(b => b.BlogId == BlogId);
                return blog;
            }
            catch (Exception)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }

        }

        public async Task<List<Blog>> GetListBlogs()
        {
            try
            {
                return await _blogRepository.Query()
                    .Include(b => b.Account)
                        .ThenInclude(a => a.TourCompany)
                    .Include(b => b.Account)
                        .ThenInclude(a => a.TouristFacility)
                    .Where(b => b.BlogStatus == BlogStatus.Approval)
                    .ToListAsync();
            }
            catch (Exception)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }

        }
        public async Task<List<Blog>> GetListBlogs_CM()
        {
            try
            {
                return await _blogRepository.Query()
                    .Include(b => b.Account)
                        .ThenInclude(a => a.TourCompany)
                    .Include(b => b.Account)
                        .ThenInclude(a => a.TouristFacility)
                        .OrderByDescending(x => x.CreateDate)
                    .ToListAsync();
            }
            catch (Exception)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }

        }
        public async Task<PagedResult<Blog>> GetListBlogs(string? search, BlogType? blogtype, int page, int pageSize)
        {
            try
            {
                var query = _blogRepository.Query()
                                .Include(b => b.Account)
                                    .ThenInclude(a => a.TourCompany)
                                .Include(b => b.Account)
                                    .ThenInclude(a => a.TouristFacility)
                                .Where(b => b.BlogStatus == BlogStatus.Approval);

                if (!string.IsNullOrEmpty(search))
                {
                    string searchConvert = search.ToLower();
                    query = query.Where(b =>
                        b.Title.ToLower().Contains(searchConvert) ||
                        b.Description.ToLower().Contains(searchConvert) ||
                        b.Content.ToLower().Contains(searchConvert)
                    );
                }

                if (blogtype.HasValue)
                {
                    query = query.Where(b => b.BlogType == blogtype);
                }

                int totalItems = await query.CountAsync();

                var blogs = await query
                    .OrderByDescending(b => b.CreateDate)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                return new PagedResult<Blog>
                {
                    Items = blogs,
                    TotalItems = totalItems,
                    CurrentPage = page,
                    PageSize = pageSize,
                    TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize)
                };
            }
            catch (Exception)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }

        }
        public async Task<Blog> CreateBlogAsync(Blog blog)
        {
            blog.BlogStatus = BlogStatus.Approval;
            blog.BlogId = Guid.NewGuid();
            blog.CreateDate = DateTime.UtcNow;

            await _blogRepository.AddAsync(blog);
            return blog;
        }

        public async Task<bool> UpdateBlogAsync(Guid blogId, Blog blog)
        {
            var existingBlog = await _blogRepository.GetByIdAsync(blogId);
            if (existingBlog == null)
            {
                return false;
            }

            existingBlog.Title = blog.Title;
            existingBlog.Content = blog.Content;
            existingBlog.LinkImg = blog.LinkImg;
            existingBlog.Description = blog.Description;
            existingBlog.BlogType = blog.BlogType;
            existingBlog.BlogStatus = blog.BlogStatus;
            existingBlog.ReplyRequest = blog.ReplyRequest;
            existingBlog.UpdateTime = DateTime.UtcNow;

            await _blogRepository.UpdateAsync(existingBlog);
            return true;
        }
        public async Task<bool> UpdateStatusAsync(Guid blogId, BlogStatus newStatus, string replyContent)
        {
            var blog = await _blogRepository.Query().FirstOrDefaultAsync(b => b.BlogId == blogId);
            if (blog == null)
            {
                throw new KeyNotFoundException("Không tìm thấy bài viết!");
            }

            blog.BlogStatus = newStatus;
            blog.ReplyRequest = replyContent;
            blog.UpdateTime = DateTime.UtcNow;

            await _blogRepository.UpdateAsync(blog);
            return true;
        }

    }
}
