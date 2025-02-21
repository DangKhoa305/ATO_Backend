using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class UserSupportSeeder
    {
        /*
        {C55339F0-3FC2-4DE6-8CA5-C78A49248981}
        */
        private readonly ModelBuilder modelBuilder;

        public UserSupportSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<UserSupport>().HasData(
                new UserSupport()
                {
                    SupportId = Guid.Parse("D549690A-59DA-4C91-8179-7BA2102800E2"),
                    IssueType = IssueType.LoginIssue,
                    Fullname = "Nguyễn Việt Thắng",
                    Email = "thangnvse151000@fpt.edu.vn",
                    IsResolved = false,
                    SupportMessage = "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!",
                    RequestDate = DateTime.Now
                },
                new UserSupport()
                {
                    SupportId = Guid.Parse("B3F8BE2E-B550-472E-BA86-035476B4296D"),
                    IssueType = IssueType.LoginIssue,
                    Fullname = "Nguyễn Việt Thắng",
                    Email = "thangnvse151000@fpt.edu.vn",
                    IsResolved = false,
                    SupportMessage = "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!",
                    RequestDate = DateTime.Now
                },
                new UserSupport()
                {
                    SupportId = Guid.Parse("17B8CAC1-6F3B-4915-BDFF-9C79A7038D15"),
                    IssueType = IssueType.LoginIssue,
                    Fullname = "Nguyễn Việt Thắng",
                    Email = "thangnvse151000@fpt.edu.vn",
                    IsResolved = false,
                    SupportMessage = "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!",
                    RequestDate = DateTime.Now
                },
                new UserSupport()
                {
                    SupportId = Guid.Parse("43AD2D80-0753-48C1-B699-8A0267205D33"),
                    IssueType = IssueType.LoginIssue,
                    Fullname = "Nguyễn Văn Anh",
                    Email = "anhNv@gmail.com",
                    IsResolved = true,
                    SupportMessage = "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!",
                    RequestDate = DateTime.Now,
                    ResponeBy = Guid.Parse("B8C777A9-55B9-4B3D-860A-D7B56E4C24B7"),
                    ResponseDate = DateTime.Now,
                    ResponseMessage = "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại."
                },
                new UserSupport()
                {
                    SupportId = Guid.Parse("C55339F0-3FC2-4DE6-8CA5-C78A49248981"),
                    IssueType = IssueType.LoginIssue,
                    Fullname = "Lê Văn Bình",
                    Email = "BinhLeV@gmail.com",
                    IsResolved = true,
                    SupportMessage = "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!",
                    RequestDate = DateTime.Now,
                    ResponeBy = Guid.Parse("B8C777A9-55B9-4B3D-860A-D7B56E4C24B7"),
                    ResponseDate = DateTime.Now,
                    ResponseMessage = "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại."
                },
                new UserSupport()
                {
                    SupportId = Guid.Parse("114F2C5F-1BD9-40DB-B843-439BC8977870"),
                    IssueType = IssueType.LoginIssue,
                    Fullname = "Nguyễn Thị Lan Anh",
                    Email = "AnhNLV1203@gmail.com",
                    IsResolved = true,
                    SupportMessage = "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!",
                    RequestDate = DateTime.Now,
                    ResponeBy = Guid.Parse("B8C777A9-55B9-4B3D-860A-D7B56E4C24B7"),
                    ResponseDate = DateTime.Now,
                    ResponseMessage = "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại."
                },
                new UserSupport()
                {
                    SupportId = Guid.Parse("B90B8B8F-0A33-419C-9E44-A69531155625"),
                    IssueType = IssueType.LoginIssue,
                    Fullname = "Nguyễn Thị Lan Anh",
                    Email = "AnhNLV1203@gmail.com",
                    IsResolved = true,
                    SupportMessage = "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!",
                    RequestDate = DateTime.Now,
                    ResponeBy = Guid.Parse("B8C777A9-55B9-4B3D-860A-D7B56E4C24B7"),
                    ResponseDate = DateTime.Now,
                    ResponseMessage = "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại."
                },
                new UserSupport()
                {
                    SupportId = Guid.Parse("80776A2C-237F-4F1A-B014-A8C40698F02E"),
                    IssueType = IssueType.LoginIssue,
                    Fullname = "Nguyễn Thị Lan Anh",
                    Email = "AnhNLV1203@gmail.com",
                    IsResolved = true,
                    SupportMessage = "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!",
                    RequestDate = DateTime.Now,
                    ResponeBy = Guid.Parse("B8C777A9-55B9-4B3D-860A-D7B56E4C24B7"),
                    ResponseDate = DateTime.Now,
                    ResponseMessage = "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại."
                }
            );
        }
    }
}
