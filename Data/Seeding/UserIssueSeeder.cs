using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class UserIssueSeeder
    {
        /*
        {C55339F0-3FC2-4DE6-8CA5-C78A49248981}
        */
        private readonly ModelBuilder modelBuilder;

        public UserIssueSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<UserIssue>().HasData(
                new UserIssue()
                {
                    IssueId = Guid.NewGuid(),
                    IssueType = IssueType.LoginIssue,
                    CreatedDate = DateTime.Now,
                    IssueDescription = "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.",
                    SolutionContent = "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn."
                },
                new UserIssue()
                {
                    IssueId = Guid.NewGuid(),
                    IssueType = IssueType.SystemBug,
                    CreatedDate = DateTime.Now,
                    IssueDescription = "Lỗi không thể thêm sản phẩm vào giỏ hàng.",
                    SolutionContent = "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết."
                },
                new UserIssue()
                {
                    IssueId = Guid.NewGuid(),
                    IssueType = IssueType.PerformanceIssue,
                    CreatedDate = DateTime.Now,
                    IssueDescription = "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.",
                    SolutionContent = "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang."
                },
                new UserIssue()
                {
                    IssueId = Guid.NewGuid(),
                    IssueType = IssueType.IntegrationIssue,
                    CreatedDate = DateTime.Now,
                    IssueDescription = "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.",
                    SolutionContent = "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần."
                },
                new UserIssue()
                {
                    IssueId = Guid.NewGuid(),
                    IssueType = IssueType.AccountLocked,
                    CreatedDate = DateTime.Now,
                    IssueDescription = "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.",
                    SolutionContent = "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ."
                },
                new UserIssue()
                {
                    IssueId = Guid.NewGuid(),
                    IssueType = IssueType.PermissionIssue,
                    CreatedDate = DateTime.Now,
                    IssueDescription = "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.",
                    SolutionContent = "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật."
                },
                new UserIssue()
                {
                    IssueId = Guid.NewGuid(),
                    IssueType = IssueType.FailedPayment,
                    CreatedDate = DateTime.Now,
                    IssueDescription = "Thanh toán không thành công do lỗi ngân hàng.",
                    SolutionContent = "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân."
                },
                new UserIssue()
                {
                    IssueId = Guid.NewGuid(),
                    IssueType = IssueType.RefundRequest,
                    CreatedDate = DateTime.Now,
                    IssueDescription = "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.",
                    SolutionContent = "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền."
                },
                new UserIssue()
                {
                    IssueId = Guid.NewGuid(),
                    IssueType = IssueType.IncorrectCharge,
                    CreatedDate = DateTime.Now,
                    IssueDescription = "Người dùng bị trừ sai số tiền khi thanh toán.",
                    SolutionContent = "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn."
                },
                new UserIssue()
                {
                    IssueId = Guid.NewGuid(),
                    IssueType = IssueType.FeatureRequest,
                    CreatedDate = DateTime.Now,
                    IssueDescription = "Cần thêm tính năng xuất báo cáo sang Excel.",
                    SolutionContent = "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp."
                },
                new UserIssue()
                {
                    IssueId = Guid.NewGuid(),
                    IssueType = IssueType.DataUpdateRequest,
                    CreatedDate = DateTime.Now,
                    IssueDescription = "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).",
                    SolutionContent = "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng."
                },
                new UserIssue()
                {
                    IssueId = Guid.NewGuid(),
                    IssueType = IssueType.Other,
                    CreatedDate = DateTime.Now,
                    IssueDescription = "Vấn đề khác không thuộc các danh mục trên.",
                    SolutionContent = "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết."
                }
            );

        }
    }
}
