using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class UserSupport
    {
        public Guid SupportId { get; set; }
        public IssueType IssueType { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string SupportMessage { get; set; }
        public DateTime RequestDate { get; set; } = DateTime.UtcNow;
        public Guid? ResponeBy { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string? ResponseMessage { get; set; }
        public bool IsResolved { get; set; } = false;
        public DateTime? UpdatedDate { get; set;}
        public virtual Account? ResponeAccount { get; set; }

    }
    public enum IssueType
    {
        [Description("Lỗi phần mềm hoặc chức năng không hoạt động đúng")]
        SystemBug,
        [Description("Hệ thống chậm, tải trang lâu")]
        PerformanceIssue,
        [Description("Lỗi kết nối API hoặc tích hợp hệ thống khác")]
        IntegrationIssue,
        [Description("Không đăng nhập được")]
        LoginIssue,
        [Description("Tài khoản bị khóa hoặc vô hiệu hóa")]
        AccountLocked,
        [Description("Không có quyền truy cập vào chức năng cần thiết")]
        PermissionIssue,
        [Description("Thanh toán không thành công")]
        FailedPayment,
        [Description("Yêu cầu hoàn tiền")]
        RefundRequest,
        [Description("Sai lệch về số tiền bị trừ")]
        IncorrectCharge,
        [Description("Đề xuất tính năng mới")]
        FeatureRequest,
        [Description("Yêu cầu cập nhật thông tin cá nhân hoặc dữ liệu")]
        DataUpdateRequest,
        [Description("Khác")]
        Other
    }
}
