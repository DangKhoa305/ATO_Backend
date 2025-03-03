using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class BlogCreateRequest
    {
        // Tên của bài viết
        public string Title { get; set; }
        // Link ảnh hiển thị của blog
        public string LinkImg { get; set; }
        // Mô tả ngắn về bài viết
        public string Description { get; set; }
        // Nội dung bài viết
        public string Content { get; set; }
        // Loại bài viết
        public BlogType BlogType { get; set; }

    }
    public class BlogUpdateRequest
    {
        // Tên của bài viết
        public string Title { get; set; }
        // Link ảnh hiển thị của blog
        public string LinkImg { get; set; }
        // Mô tả ngắn về bài viết
        public string Description { get; set; }
        // Nội dung bài viết
        public string Content { get; set; }
        // Loại bài viết
        public BlogType BlogType { get; set; }
        // Trạng thái bài viết
        public BlogStatus BlogStatus { get; set; }
        // Nội dung phản hồi
        public string? ReplyRequest { get; set; }

    }
}