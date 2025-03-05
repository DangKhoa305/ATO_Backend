using Data.Models;
using Service.PageResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BlogSer
{
    public interface IBlogService
    {
        Task<List<Blog>> GetListBlogs();
        Task<List<Blog>> GetListBlogs_CM();
        Task<Blog> GetBlogDetails(Guid BlogId);
        Task<Blog> CreateBlogAsync(Blog blog);
        Task<bool> UpdateBlogAsync(Guid blogId, Blog blog);
        Task<bool> UpdateStatusAsync(Guid blogId, BlogStatus newStatus, string replyContent);
        Task<PagedResult<Blog>> GetListBlogs(string? search, BlogType? blogtype, int page, int pageSize);
    }
}

