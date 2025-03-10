using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Blog
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
        public Guid CreateBy { get; set; }
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

        // FK
        public virtual Account? Account { get; set; }
    }
    public enum BlogType
    {
        [Description("Sự kiện")]
        Even = 1,
        [Description("Tin tức")]
        News = 2,
    }
    public enum BlogStatus
    {
        [Description("Chấp thuận")]
        Approval,
        [Description("Đang xử lý")]
        Processing,
        [Description("Từ chối")]
        Reject,
    }
}
