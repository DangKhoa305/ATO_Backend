using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class Blog_Guest_DTO
    {
        public Guid BlogId { get; set; }
        public string Title { get; set; }
        public string LinkImg { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string CreateByName { get; set; }
        public Guid? TourCompanyId { get; set; }
        public Guid? TouristFacilityId { get; set; }
        public BlogType BlogType { get; set; }
        public DateTime CreateDate { get; set; }
        public string DescriptionAPI { get; set; } = "BlogType( 0-Sự kiện, 1-Tin tức )";
    }
    public class Blog_CM_DTO
    {
        public Guid BlogId { get; set; }
        // Tên của bài viết
        public string Title { get; set; }
        // Link ảnh hiển thị của blog
        public string LinkImg { get; set; }
        // Mô tả ngắn về bài viết
        public string Description { get; set; }
        // Nội dung bài viết
        public string Content { get; set; }
        // Tạo bởi
        public string CreateByName { get; set; }
        public Guid? TourCompanyId { get; set; }
        public Guid? TouristFacilityId { get; set; }
        // Loại bài viết
        public BlogType BlogType { get; set; }
        // Trạng thái bài viết
        public BlogStatus BlogStatus { get; set; }
        // Nội dung phản hồi
        public string? ReplyRequest { get; set; }
        // Thời gian tạo
        public DateTime CreateDate { get; set; }
        // Thời gian chỉnh sửa gần nhất
        public DateTime? UpdateTime { get; set; }

        public string DescriptionAPI { get; set; } = "BlogType( 0-Sự kiện, 1-Tin tức )";
    }
}
