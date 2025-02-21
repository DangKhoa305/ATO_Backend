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
        Task<Blog> GetBlogDetails(Guid BlogId);
        Task<PagedResult<Blog>> GetListBlogs(string? search, BlogType? blogtype, int page, int pageSize);
    }
}
