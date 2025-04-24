using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class UserSupportDetails
    {
        public Guid SupportId { get; set; }
        public IssueType IssueType { get; set; }
        public string IssueTypeDescription { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string SupportMessage { get; set; }
        public DateTime RequestDate { get; set; } = DateTime.UtcNow;
        public DateTime? ResponseDate { get; set; }
        public string? ResponseMessage { get; set; }
        public bool IsResolved { get; set; } = false;
        public DateTime? UpdatedDate { get; set; }
        public string? ResponeBy { get; set; }
        public string? ListIssueType { get; set; } =
            "0 - SystemBug - Lỗi phần mềm hoặc chức năng không hoạt động đúng ;" +
            "1 - PerformanceIssue - Hệ thống chậm, tải trang lâu ;" +
            "2 - IntegrationIssue - Lỗi kết nối API hoặc tích hợp hệ thống khác;" +
            "3 - LoginIssue - Không đăng nhập được;" +
            "4 - AccountLocked - Tài khoản bị khóa hoặc vô hiệu hóa;" +
            "5 - PermissionIssue - Không có quyền truy cập vào chức năng cần thiết;" +
            "6 - FailedPayment - Thanh toán không thành công;" +
            "7 - RefundRequest - Yêu cầu hoàn tiền;" +
            "8 - IncorrectCharge - Sai lệch về số tiền bị trừ; " +
            "9 - FeatureRequest - Đề xuất tính năng mới; " +
            "10 - DataUpdateRequest- Yêu cầu cập nhật thông tin cá nhân hoặc dữ liệu;" +
            "11 - Other - Khác;";

    }

}
