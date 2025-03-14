using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class CertificationSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public CertificationSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Certification>().HasData(
                new Certification()
                {
                    CertificationId = Guid.NewGuid(),
                    ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    CertificationName = "Chứng nhận OCOP",
                    IssueDate = DateTime.Now,
                    ExpiryDate = DateTime.Now,
                    CertificationDetails = "Sản phẩm: Viên nghệ mật ong \r\n" +
                    " Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n" +
                    " Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\n" +
                    "Đã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022",
                    CreateDate = DateTime.Now,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = "Yêu cầu xác nhận chứng chỉ được phê duyệt!",
                    IssuingOrganization = "Ủy ban nhân dân xã"
                },
                new Certification()
                {
                    CertificationId = Guid.NewGuid(),
                    ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    CertificationName = "Chứng nhận OCOP",
                    IssueDate = DateTime.Now,
                    ExpiryDate = DateTime.Now,
                    CertificationDetails = "Sản phẩm: Tinh Bột Sắn Dây \r\n" +
                    " Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n" +
                    " Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\n" +
                    "Đã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022",
                    CreateDate = DateTime.Now,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = "Yêu cầu xác nhận chứng chỉ được phê duyệt!",
                    IssuingOrganization = "Ủy ban nhân dân xã"
                },
                new Certification()
                {
                    CertificationId = Guid.NewGuid(),
                    ProductId = Guid.Parse("798A3B9B-F7C9-4E84-A563-39421E6585F4"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    CertificationName = "Chứng nhận OCOP",
                    IssueDate = DateTime.Now,
                    ExpiryDate = DateTime.Now,
                    CertificationDetails = "Sản phẩm: Cơm cháy \r\n" +
                    " Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n" +
                    " Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\n" +
                    "Đã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022",
                    CreateDate = DateTime.Now,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = "Yêu cầu xác nhận chứng chỉ được phê duyệt!",
                    IssuingOrganization = "Ủy ban nhân dân xã"
                }
                ,
                new Certification()
                {
                    CertificationId = Guid.NewGuid(),
                    ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    CertificationName = "Chứng nhận OCOP",
                    IssueDate = DateTime.Now,
                    ExpiryDate = DateTime.Now,
                    CertificationDetails = "Sản phẩm: Dầu gội dược liệu \r\n" +
                    " Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n" +
                    " Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\n" +
                    "Đã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022",
                    CreateDate = DateTime.Now,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = "Yêu cầu xác nhận chứng chỉ được phê duyệt!",
                    IssuingOrganization = "Ủy ban nhân dân xã"
                },
                new Certification()
                {
                    CertificationId = Guid.NewGuid(),
                    ProductId = Guid.Parse("69006CFE-5233-4B8E-B181-D81A485873E3"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    CertificationName = "Chứng nhận OCOP",
                    IssueDate = DateTime.Now,
                    ExpiryDate = DateTime.Now,
                    CertificationDetails = "Sản phẩm: Trà Sen Tây Hồ \r\n" +
                    " Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n" +
                    " Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\n" +
                    "Đã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022",
                    CreateDate = DateTime.Now,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = "Yêu cầu xác nhận chứng chỉ được phê duyệt!",
                    IssuingOrganization = "Ủy ban nhân dân xã"
                },
                new Certification()
                {
                    CertificationId = Guid.NewGuid(),
                    ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    CertificationName = "Chứng nhận OCOP",
                    IssueDate = DateTime.Now,
                    ExpiryDate = DateTime.Now,
                    CertificationDetails = "Sản phẩm: Ống rượu tre Việt Nam \r\n" +
                    " Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n" +
                    " Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\n" +
                    "Đã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022",
                    CreateDate = DateTime.Now,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = "Yêu cầu xác nhận chứng chỉ được phê duyệt!",
                    IssuingOrganization = "Ủy ban nhân dân xã"
                },
                new Certification()
                {
                    CertificationId = Guid.NewGuid(),
                    ProductId = Guid.Parse("639E1CFC-1266-4B30-9022-3927C1721AFD"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    CertificationName = "Chứng nhận OCOP",
                    IssueDate = DateTime.Now,
                    ExpiryDate = DateTime.Now,
                    CertificationDetails = "Sản phẩm: Bột tía tô \r\n" +
                    " Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n" +
                    " Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\n" +
                    "Đã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022",
                    CreateDate = DateTime.Now,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = "Yêu cầu xác nhận chứng chỉ được phê duyệt!",
                    IssuingOrganization = "Ủy ban nhân dân xã"
                },
                new Certification()
                {
                    CertificationId = Guid.NewGuid(),
                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    CertificationName = "Chứng nhận OCOP",
                    IssueDate = DateTime.Now,
                    ExpiryDate = DateTime.Now,
                    CertificationDetails = "Sản phẩm: Nhang trầm hương \r\n" +
                    " Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n" +
                    " Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\n" +
                    "Đã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022",
                    CreateDate = DateTime.Now,
                    StatusApproval = StatusApproval.Processing,
                    IssuingOrganization = "Ủy ban nhân dân xã"
                },
                new Certification()
                {
                    CertificationId = Guid.NewGuid(),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    CertificationName = "Chứng nhận TQC",
                    IssueDate = DateTime.Now,
                    ExpiryDate = DateTime.Now,
                    CertificationDetails = "Chứng nhận hệ thống quản lý chất lượng",
                    CreateDate = DateTime.Now,
                    StatusApproval = StatusApproval.Reject,
                    ReplyRequest = "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!",
                    IssuingOrganization = "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL"
                },
                new Certification()
                {
                    CertificationId = Guid.NewGuid(),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    CertificationName = "Chứng nhận chất lượng sản phẩm",
                    IssueDate = DateTime.Now,
                    ExpiryDate = DateTime.Now,
                    CertificationDetails = "Chứng nhận chất lượng sản phẩm",
                    CreateDate = DateTime.Now,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = "Yêu cầu xác nhận chứng chỉ được phê duyệt!",
                    IssuingOrganization = "Tổng cục tiêu chuẩn đo lường chất lượng"
                }
            );
        }
    }
}
