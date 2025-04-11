using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class ProductSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public ProductSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                   ProductName = "[OCOP - 500 gr] Viên Tinh Nghệ Mật Ong Hoàng Mai Nguyên Chất - Hỗ Trợ Giảm Đau Dạ Dày, Làm Đẹp Da, Lưu Thông Máu",
                   Imgs = new List<string>()
                   {
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-lmyybsw1u1274a%40resize_w900_nl.webp?alt=media&token=8df7ec0c-528c-4420-b9d8-1aa642cf458b",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-ln887g33oi54f0%40resize_w900_nl.webp?alt=media&token=e4a624c3-296d-4553-812e-c17832510225",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-lnq49wxk2v7ea0%40resize_w900_nl.webp?alt=media&token=b6600b96-94ef-473e-ba86-72a4f5568635",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqd729rck56%40resize_w900_nl.webp?alt=media&token=2df35c4e-8b69-4210-80f3-58f6dee45ac5",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqlwlhj90fe%40resize_w900_nl.webp?alt=media&token=bddafaae-310a-421f-ac7d-ba10a052b63a"
                   },
                   Description = "Viên Nghệ Mật Ong Hoàng Mai Nguyên Chất - Hỗ Trợ Giảm Đau Dạ Dày, Làm Đẹp Da\r\n\r\n1. Thông tin sản phẩm:\r\n- Quy cách đóng gói: 500gr\r\n- Hạn sử dụng: 18 tháng \r\n- Xuất xứ: Việt Nam\r\n-  Hoàng Mai, tỉnh Nghệ An\r\n- Chứng chỉ: Chứng nhận OCOP 3 sao\r\n- Thương hiệu: HTX Đồng Tâm\r\n\r\n2. Ưu điểm nổi bật\r\n- Sản phẩm đạt chuẩn chất lượng tiêu chuẩn OCOP.\r\n- Áp dụng công nghệ bào chế tinh bột nghệ Nano Curcumin.\r\n- Thành phần: tinh bột nghệ, mật ong tự nhiên nguyên chất không pha tạp.\r\n- Tinh chế từ 100% nguyên liêu tự nhiên không hóa chất bảo quản.\r\n\r\n3. Công dụng sản phẩm\r\n- Hỗ trợ đường tiêu hoá: phòng các chứng viêm va giảm đau dạ dày ( bao tử), đại tràng, bệnh đường ruột.\r\n- Giảm mụn, nám, tàng nhang, thâm sạm, ngăn ngừa lão hoá từ bên trong giúp dưỡng nhan, làm hồng hào da, nhuận sắc\r\n- Lưu thông m.á.u, hỗ trợ các bệnh viêm khớp, tim mạch, tiểu đường\r\n- Làm hạ huyết áp, giảm cholesterol\r\n- Giúp an thần, ngủ ngon \r\n- Tăng cường sinh lực cho phái mạnh\r\n- Cải thiện sức khoẻ, sắc đẹp đẹp cho phụ nữ sau sinh\r\n\r\n4. Hướng dẫn sử dụng:\r\n- Viên nghê mật ong Hoàng Mai thơm ngon, khá mềm nên có thể nhai trực tiếp hoặc kết hợp uống với nước.\r\n- Nếu đau dạ dày nặng ngày dùng 3 lần, 5-7 viên/ lần sau khi ăn, khoảng 1 tháng đã cải thiện nên giảm tần suất dùng xuống ngày 2 lần \r\n- Uống tốt sức khỏe & tái tạo – trẻ hóa da ngày dùng 2 lần, 3-5 viên/ lần.\r\n- Các mẹ ở cử, sau sanh khoảng 7 ngày-10 ngày khi xuống sạch dịch và huyết thì dùng ngày dùng 3 lần, 5 viên/ lần.\r\n- Trẻ em trên 2 đến 6 tuổi ngày dùng 2 lần, 2-3 viên/ lần.\r\n*** Lưu ý: Phụ nữ mang thai, người bị sỏi thận, sỏi mật, người chuẩn bị phẩu thuật, trẻ em dưới 2 tuổi không nên dùng.\r\n\r\n5. Hướng dẫn bảo quản viên tinh bột nghệ mật ong Hoàng Mai\r\n- Để nơi thoáng mát, tránh tiếp xúc ánh nắng mặt trời.\r\n- Không nên đặt dưới nền đất lạnh, sẽ ảnh hưởng đến chất lượng.\r\n- Tránh để nước hoặc không khí tiếp xúc với sản phẩm, sẽ gây ẩm mốc.\r\n- Đậy nắp kín trước và sau khi sử dụng. \r\n\r\n6. Quy trình đổi trả sản phẩm nếu có lỗi từ nhà sản xuất theo quy định của Shopee.\r\n Điều kiện áp dụng (trong vòng 03 ngày kể từ khi nhận sản phẩm):\r\n- Vui lòng quay video mở hàng (shop chỉ giải quyết đơn hàng khi có video mở hàng)\r\n- Hàng hóa hư hỏng do vận chuyển hoặc do nhà sản xuất.\r\n- Không đủ số lượng như trong đơn hàng.\r\n\r\nSẢN PHẨM NÀY KHÔNG PHẢI LÀ THUỐC VÀ KHÔNG CÓ TÁC DỤNG THAY THẾ THUỐC CHỮA BỆNH.\r\n#Viennghe #Vientinhnghe #Viennghematong #Vientinhnghematong #Matong  #Suaongchua #tinhbotnghe #tinhbot #botnghevang #nghe #tinhbotnghevang #tinhbotnghethiennhien #tinhbotnghehuuco #tinhbotnghetunhien #tinhbotnghexuatkhau #sanxuattinhbotnghe #vientinhbotnghe #vientinhbot #nghevang #shopmall #Shopuytin #ocop",
                   UnitProduct = UnitProduct.g,
                   Price = 80000,
                   ProductCategory = ProductCategory.HerbalMedicine,
                   CreateDate = DateTime.Now,
                   TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                   Additional = "Tiêu hóa & gan, Tim mạch & huyết áp, Khả năng miễn dịch, Khớp, cơ bắp & Xương, Căng thẳng, giấc ngủ, và nlo lắng",
                   Age = "Người lớn",
                   Volume = "500ml",
                   NutritionType = "Nghệ",
                   Ingredient = "Tinh bột nghệ, Mật ong nguyên chất",
                   Origin = "Việt Nam",
                   Manufacturer = "Xưởng Mộc Việt",
                   AddressManufacturer = "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị",
                   StatusApproval = StatusApproval.Approved
               },
               new Product()
               {
                   ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                   ProductName = "[OCOP] Tinh Bột Sắn Ta Dây Nguyên Chất 100% Vị Chanh Leo 500g - Thanh Nhiệt, Giải Độc, Mát Gan, Đẹp Da - Làm Thủ Công",
                   Imgs = new List<string>()
                   {
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-1.webp?alt=media&token=4d8cfdbb-9f89-4e0b-9026-eeb3b551ea0c",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-2.webp?alt=media&token=bad36b93-8f59-4463-8622-b0a7ea89821e",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-3.webp?alt=media&token=d111fa72-4b38-4bfc-9c7b-9b5111eadb07",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-4.webp?alt=media&token=7c347385-45bd-474f-9930-77dca305655c",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-5.webp?alt=media&token=b6b5ea5e-dee5-4c3f-ac83-231fe6bd4a68",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-6.webp?alt=media&token=d3542914-5791-4d36-95a6-071e554aa407",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-7.webp?alt=media&token=4126eb69-2b91-4c39-a8dc-f548b1b9bbd6"
                   },
                   Description = "Tinh Bột Sắn Dây Nguyên Chất Vị Chanh Leo Đồng Tâm 500g - Hỗ Trợ Thanh Nhiệt, Giải Độc, Mát Gan\r\n\r\nI. THÔNG TIN SẢN PHẨM: \r\n- Xuất xứ: Việt Nam\r\n- Quy cách đóng gói: Hộp 500 gram\r\n- Hạn sử dụng: 18 tháng kể từ NSX\r\n- Thành phần: 100 % Nguyên chất bột sắn dây\r\n\r\nII. CÔNG DỤNG: \r\n- Đồ uống thanh nhiệt giải độc do nóng gan, làm trắng da sáng da từ bên trong. Giải nhiệt, rôm sảy, nóng trong người. Giảu rượu giúp cơ thể tỉnh táo, nhanh hồi phục.              \r\n- Chất làm đặc thực phẩm: Tinh bột sắn dây thường được sử dụng như một chất làm đặc trong các món tráng miệng, nước ép, nước uống và các món canh sệt. Nó giúp tăng độ đặc và nhờn cho các món ăn mà không thay đổi hương vị hay màu sắc của chúng.\r\n- Thành phần trong sản phẩm làm đẹp: Tinh bột sắn dây có khả năng hấp thụ dầu và làm dịu da, nên nó thường được sử dụng trong các sản phẩm chăm sóc da. \r\n- Thức ăn bổ sung: Tinh bột sắn dây có chứa chất xơ và chất dinh dưỡng có lợi như kali, canxi và vitamin C. Việc tiêu thụ tinh bột sắn dây có thể giúp cải thiện tiêu hóa, hỗ trợ sự chuyển hóa chất béo, giảm cholesterol và duy trì sự ổn định của đường huyết.\r\n- Sản phẩm không chứa gluten: Tinh bột sắn dây không chứa gluten, là một lựa chọn tuyệt vời cho những người có chứng dị ứng hoặc nhạy cảm với gluten. Nó có thể được sử dụng để thay thế tinh bột từ các nguồn ngũ cốc khác trong nấu ăn và nướng bánh.\r\n- Tạo mặt nạ tự nhiên: Tinh bột sắn dây có thể được kết hợp với các nguyên liệu tự nhiên khác như mật ong, sữa chua, bột trà xanh để tạo mặt nạ tự nhiên.\r\n\r\nIII. CÁCH SỬ DỤNG:\r\nTheo Đông Y, bột sắn dây có vị ngọt, mát, tính bình nên cây thường được sử dụng trong việc thanh nhiệt và giải độc. Còn theo y học hiện đại thành phần hoạt chất có trong bột sắn dây góp phần ngăn ngừa một số b.ệ.n.h. Sau đây là một số cách sử dụng bột sắn dây.\r\n- Cảm nắng, nhức đầu, sốt nóng: Sử dụng khoảng 12g bột sắn dây hòa vào nước cùng với một chút đường để uống.\r\n- Đau bụng đi ngoài giống kiết lỵ: Sử dụng bột sắn dây hòa vào nước cùng với một chút đường để uống.\r\n- Loại bỏ và ngăn ngừa cảm, nôn, đau đầu ở trẻ nhỏ do bị cảm, gió: Nấu chín bột sắn dây cùng gạo tẻ thành cháo, thêm gừng giã nát và mật ong, cho trẻ ăn từ 3 - 5 ngày.\r\n- Chống ngứa do mồ hôi gây nên: 5g bột sắn dây, 5g thiên hoa phấn, 20g hoạt thạch. Trộn đều hỗn hợp rồi rắc lên những khu vực bị ngứa.\r\n- Vùng ngực và bụng cảm thấy nóng cồn cào, khát nước: lấy 120g sắn dây trộn đều với 15g gạo tẻ, sử dụng để nấu cháo, ăn từ 3 - 5 ngày sẽ làm thuyên giảm tình trạng trên.\r\n- Loại bỏ kiết lỵ do nhiệt: Để loại bỏ đau bụng, nóng rát vùng hậu môn, phải rặn khi đại tiện, pha bột sắn dây với nước và đường, sau đó nấu chín đặc và ăn trong 2 - 3 lần/ngày.\r\n- Ngăn ngừa viêm họng: bột sắn dây giúp cơ thể ức chế một số v.i k.huẩn có h.ại. Vì thế, nếu bị viêm họng, bạn có thể lấy từ 10-15g bột pha nước nóng để uống. Sau vài ngày triệu chứng viêm họng sẽ chấm dứt hoàn toàn.\r\n- Hết n.gộ đ.ộc r.ượu: Hòa tan bột sắn dây với một chút đường có thể thêm nước cốt chanh. Có thể sử dụng muối thay cho đường ",
                   UnitProduct = UnitProduct.g,
                   Price = 80000,
                   ProductCategory = ProductCategory.Food,
                   CreateDate = DateTime.Now,
                   TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                   Origin = "Việt Nam",
                   Manufacturer = "Xưởng Mộc Việt",
                   AddressManufacturer = "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị",
                   StatusApproval = StatusApproval.Approved
               },
               new Product()
               {
                   ProductId = Guid.Parse("798A3B9B-F7C9-4E84-A563-39421E6585F4"),
                   ProductName = "[BÁN SỈ] Cơm cháy 300g- 600g siêu ruốc chà bông ròn ngon Cố Đô, ocop 4 sao đặc sản Ninh Bình",
                   Imgs = new List<string>()
                   {
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F32.webp?alt=media&token=1b2c7198-56da-46dc-bef8-c1371e4bbd16",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F33.webp?alt=media&token=feac05a6-f278-4bae-85ab-4a9453decd2a",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F34.webp?alt=media&token=153f06d6-d1ee-4781-a17a-b43c0028fbea",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F35.webp?alt=media&token=0cf39ab3-b794-4d99-90a6-4d4026b690d8",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F36.webp?alt=media&token=0f2875bb-7146-4a3d-8774-d449d78a925a",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F37.webp?alt=media&token=4ef86b59-4468-4e52-af69-5084c99281c8",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F38.webp?alt=media&token=f332cd0d-fc6f-45e4-87cf-5ad8c1dfc749",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F310.webp?alt=media&token=1c52bcc3-1800-4c86-a874-842c62dca2af"
                   },
                   Description = "✅ Thông tin sản phẩm cơm cố đô ruốc đậm đà 300g- 600g:\r\n    1 gói 05 miếng to đùng.\r\n    Shop đóng gói thùng giấy catton chắc chắn hạn chế bể vỡ khi vận chuyển.\r\n    Trọng lượng mỗi gói cơm cháy cố đô ruốc đậm  Khoảng 600 gram/Túi\r\n\r\n✅ Cơm cháy bên mình để khô ráo dầu mới bỏ vào bịch, và chiên dầu mới để không bị gắt dầu nha các bạn.\r\n     sản phẩm đóng trong túi zips kín, sử dụng rất tiện ích\r\n     Hạn sử dụng: 6 Tháng\r\n     Nguồn gốc xuất xứ : Thành phố Ninh Bình - tỉnh Ninh Bình\r\n\r\n✅ HƯỚNG DẪN SỬ DỤNG VÀ BÀO QUẢN :\r\n- Dùng ngay khi mở miệng túi không cần chế biến.\r\n- Bảo quản nơi khô ráo, thoáng mát và tránh ánh nắng trực tiếp.\r\n \r\n✅ Shop mình tự tin là chuẩn bị hàng nhanh, sáng các bạn đặt đơn thì chiều mình gởi hàng. Tuy nhiên thời gian giao hàng còn phụ thuộc vào đơn vị giao hàng nữa, đôi khi có những trường hợp giao chậm hơn so với dự kiến. Shop mong các bạn hiểu và thông cảm ạ !\r\n\r\n✅ Thời gian giao hàng đối với các tỉnh miền bắc, miền trung: 1-3 ngày. Tỉnh phía Nam : 3-5 ngày.\r\n\r\n1 Túi 05 MIẾNG TO ĐÙNG CƠM CHÁY RUỐC HÀNH ỚT | SHOP CƠM CHÁY CỐ ĐÔ - TINH HOA NÔNG SẢN VIÊT\r\n\r\n#cơm_cháy #cơm_cháy_chà_bông #cơm_cháy_rụm #cơm_cháy_mỡ_hành #cơm_cháy_khô_gà #cơm_cháy_chiên #nước_mắm #cơm_cháy_chiên_mắm #cơm_cháy_lắc_khô_gà #cơm_cháy_mắm_hành #com_cháy_chà_bông #cơm_cháy_ngon #cơm_cháy_chà_bông_ngon #cơm_cháy_khô #cơm_cháy_mắm_ớt #cơm_cháy_chà_bông_mỡ_hành #cơm_cháy_mắm #cơm_cháy_tỏi #cơm_cháy_giá_sỉ",
                   UnitProduct = UnitProduct.g,
                   Price = 80000,
                   ProductCategory = ProductCategory.Food,
                   CreateDate = DateTime.Now,
                   TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                   Volume = "750g",
                   NutritionType = "Đặc sản địa phương",
                   Ingredient = "GẠO NẾP THƠM, RUỐC, ỚT, TIÊU",
                   Origin = "Việt Nam",
                   Manufacturer = "Xưởng Mộc Việt",
                   AddressManufacturer = "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị",
                   StatusApproval = StatusApproval.Approved
               },
               new Product()
               {
                   ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                   ProductName = "Dầu gội dược liệu Glow THỦY TÙNG 400ml, dầu gội thảo dược, dầu gội bồ kết OCOP 4 sao | Phan Nam FOOD",
                   Imgs = new List<string>()
                   {
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F42.webp?alt=media&token=fb9ba94c-fdec-47fb-b782-f145d2b611e7",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F43.webp?alt=media&token=4b849fd1-6be9-4fa5-846c-c1865071899d",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F44.webp?alt=media&token=d50897e6-af7d-47bd-bc4b-e8e196dd65af",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F45.webp?alt=media&token=facf05b2-93fb-4519-b412-b73961492d1f",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F46.webp?alt=media&token=4b7b2e0c-8882-4c0f-86b2-e362dcccabec",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F47.webp?alt=media&token=47195d9c-a6f1-4416-a67b-cae2ba719f10",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F48.webp?alt=media&token=5a284068-ab8c-486e-a50a-407e1ed4489d",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F49.webp?alt=media&token=a0c04528-e4db-427c-984d-f1ef780fd838"
                   },
                   Description = "Chào mừng bạn ghé thăm gian hàng chính hãng của PHAN NAM FOOD - cửa hàng nông sản sạch an toàn!\r\nPHAN NAM FOOD là hệ thống cửa hàng nông sản sạch chuyên cung cấp các sản phẩm đạt chuẩn OCOP, VietGap cùng những đặc sản tiêu biểu của địa phương nhằm phục vụ nhu cầu tiêu dùng của người dân được tiếp cận với những thực phẩm sạch, tươi ngon. Mong muốn giới thiệu những đặc sản địa phương tới người dân cả nước PHAN NAM FOOD chính thức có mặt trên sàn thương mại điện tử để khách hàng dễ dàng mua hàng, lựa chọn sản phẩm chất lượng cao với giá tốt nhất và được giao hàng tận nơi.\r\n\r\nTheo dõi gian hàng để nhận ngay voucher giảm giá và cập nhật nhiều chương trình khuyến mãi hấp dẫn từ PHAN NAM FOOD các bạn nhé!\r\n----------------------------\r\nTHÔNG TIN SẢN PHẨM: Dầu gội dược liệu Glow THỦY TÙNG 400ml\r\n- Thương hiệu: Thủy Tùng, sản phẩm ocop 3 sao.\r\n- Trọng lượng: 400ml\r\n- Thành phần: Nước, Bồ kết, hương nhu tía, mần trầu, chanh, vỏ bưởi, sả chanh, gừng, tinh dầu vỏ bưởi, tinh dầu sả chanh, dầu dừa.\r\n- Dầu gội chiết xuất từ những dược liệu thiên nhiên giúp chăm sóc và nuôi dưỡng tóc từ gốc đến ngọn, bảo vệ tóc khỏi các tác nhân có hại từ bên ngoài, giúp tóc sạch gàu, suôn mềm, thoáng mát da đầu.\r\n- HSD: 3 năm kể từ ngày sản xuất (NSX xem trên bao bì)\r\n- Hướng Dẫn Sử Dụng: Làm ướt tóc và da đầu, lấy khoảng 3 - 5ml dầu gội sau đó thoa đều và gội từ 3 - 5 phút rồi xả kỹ bằng nước sạch, nên gội thêm lần 2 để có hiệu quả tốt hơn.\r\n- Cách bảo quản: Nơi khô ráo, tránh ánh sáng trực tiếp.\r\n\r\n#daugoiduoclieu #daugọithaoduoc #daugoiboket #daugoikichthichmoctoc #daugoithaoduocantoan",
                   UnitProduct = UnitProduct.g,
                   Price = 80000,
                   ProductCategory = ProductCategory.HerbalMedicine,
                   CreateDate = DateTime.Now,
                   TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                   Origin = "Việt Nam",
                   Manufacturer = "Xưởng Mộc Việt",
                   AddressManufacturer = "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị",
                   StatusApproval = StatusApproval.Approved
               },
               new Product()
               {
                   ProductId = Guid.Parse("69006CFE-5233-4B8E-B181-D81A485873E3"),
                   ProductName = "Trà Sen Tây Hồ Thượng Hạng [OCOP 4⭐] - Hương Thơm Tự Nhiên, Đậm Đà Truyền Thống, Hộp 10 Bông",
                   Imgs = new List<string>()
                   {
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F51.webp?alt=media&token=5218426e-19ff-4feb-b968-93e08e7f6c92",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F52.webp?alt=media&token=65af2dec-b460-4f5c-8c4b-8c76b6581a83",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F53.webp?alt=media&token=a5f9bc6d-d647-4b36-9c9e-bf86eead7692",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F54.webp?alt=media&token=94412ff3-d1eb-427a-8114-3290d62edd31",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F55.webp?alt=media&token=1cade255-31ff-4248-ac2f-0f2f8513b33c",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F56.webp?alt=media&token=7df9da7d-de96-49bc-a5e5-15113e8bb8e0",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F57.webp?alt=media&token=d9ab3abb-2461-45e6-a22b-3cf0f2a2060f",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F58.webp?alt=media&token=8a4bda8c-0e6c-4154-8dc0-6c3c23ea8f53"
                   },
                   Description = "🌱Sản phẩm đạt tiêu chuẩn OCOP 4 SAO theo Quyết định 919/QĐ-Ttg năm 2018 của Chính phủ\r\n\r\n\r\n\r\n✅THÔNG TIN SẢN PHẨM:\r\n\r\n• Trà Sen Bách Diệp là sự hòa quyện tuyệt vời giữa hương thơm ngan ngát của sen Bách Diệp Hồ Tây và vị đậm đà của trà Tân Cương Thái Nguyên.\r\n\r\n• 100% Trà Sen Bách Diệp Tây Hồ Hà Nội được thu hái thủ công, tuyển chọn những búp chè tươi ngon. Trà được gói trọn trong bông Sen giúp cho lá trà thẩm thấu toàn bộ hương sen, sau đó được sấy thăng hoa theo công nghệ hiện đại của Đức để giữ được trong hương vị và bảo quản được lâu, khi pha tạo nên cảm giác khoan khoái và thư giãn.\r\n\r\n• Hải Linh tự hào là thương hiệu Trà sen Bách Diệp uy tín, có sản lượng tiêu thụ lớn nhất hiện nay.\r\n\r\n\r\n\r\n✅ Set quà sang trọng: Một set bao gồm: Trà Sen, hộp trà và túi xách đẹp mắt, thích hợp làm quà tặng cao cấp.\r\n\r\n- Trọng lượng: Set 10 bông trà (tổng trọng lượng 1.000g). Mỗi bông trà sen sau khi đã được sấy thăng hoa (mất hơi nước) có trọng lượng 26gram, đủ tiêu chuẩn cho 6 người uống (4gram trà / 1 người).\r\n\r\n- Trà đã được ướp bông sen sau đó sấy thăng hoa cả búp nên chỉ cần bảo quản ở nhiệt độ thường\r\n\r\n- HSD 12 tháng kể từ ngày sản xuất, NSX và HSD được in trên bao bì từng bông.\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CHI TIẾT SẢN PHẨM:\r\n\r\n• Thành phần: 100% trà xanh chất lượng được bọc bên trong búp sen tươi.\r\n\r\n• Hướng dẫn sử dụng: \r\n\r\n- Rót nước sôi để tráng ấm, chén pha trà: Giúp tiệt trùng dụng cụ pha trà và làm nóng ấm, chén pha trà.\r\n\r\n- Cho khoảng 10g trà và phần gạo sen vào trong ấm.\r\n\r\n- Châm 200ml nước sôi có nhiệt độ 75 đến 80 độ C vào ấm, rồi hãm 20-25 giây.\r\n\r\n-  Rót trà từ ấm: Hãm đủ thời gian, bạn hãy rót hết lượng trà trong ấm ra chén Tống qua chiếc lọc trà và tránh để lại nước trong ấm (Lọc trà giúp giữ lại những xác trà nhỏ giúp nước trà trong và tinh khiết hơn)\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CÔNG DỤNG CỦA TRÀ SEN: \r\n\r\n• Trà sen Bách Diệp giúp giảm lượng cholesterol trong máu, giúp ngăn ngừa bệnh tim mạch, đặc biệt tốt cho sức khỏe của người già, người mắc bệnh tim mạch. Hạn chế nguy cơ mắc các bệnh về gan, hạn chế sự hấp thu các chất béo vào cơ thể.\r\n\r\n• Tăng cường hệ miễn dịch giúp cho cơ thể giúp cơ thể chống lại những hiện tượng nhiễm virus và nhiễm khuẩn.\r\n\r\n\r\n\r\n✅ QUY CÁCH ĐÓNG GÓI: Trà và búp sen được sấy khô và hút chân không giúp giữ hương vị trà được lâu, thân thiện với môi trường.\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CHÍNH SÁCH ĐỔI TRẢ CỦA TRÀ SEN HÀ NỘI OFFICIAL : \r\n\r\n👉 1 đổi 1 trong trường hợp lỗi do nhà sản xuất, sai sản phẩm và theo quy định của Shopee. \r\n\r\n👉 Trường hợp gửi thiếu, các bạn liên hệ shop để được đổi lại, gửi bù MIỄN PHÍ. (Các bạn nhớ QUAY CLIP BÓC HÀNG để được giải quyết nhé).\r\n\r\n\r\n\r\n#tràbúpsen #tràbôngsen #tràngon #tràcaocấp #chèbúpsen #tràsen #tràướphoasen #tràsentâyhồ #tràhoasen #trà #tràbiếu #sentrà #tràướpsentâyhồ #chèướpsen #tràướpbôngsen #chèsen #chèsentâyhồ #tràsenhànội #chèhoasen",
                   ProductCategory = ProductCategory.Beverage,
                   Price = 80000,
                   CreateDate = DateTime.Now,
                   TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                   Additional = "Trà túi lọc & lá trà",
                   Volume = "10 bông",
                   NutritionType = "Truyền thống",
                   Ingredient = "Trà xanh, Khác",
                   Origin = "Việt Nam",
                   Manufacturer = "Xưởng Mộc Việt",
                   AddressManufacturer = "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị",
                   StatusApproval = StatusApproval.Approved
               },
               new Product()
               {
                   ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                   ProductName = "Ống rượu tre Việt Nam - Sản phẩm đạt chứng nhận Ocop 3 Sao [ Quà Tết Hot 2024 ]",
                   Imgs = new List<string>()
                   {
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F62.webp?alt=media&token=5e7d93e8-e10e-47e1-be82-573a9436bdca",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F63.webp?alt=media&token=7b8fd32b-486b-4fec-bb89-ec59959708d0",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F64.webp?alt=media&token=d7b0593b-a8a7-44de-917a-35e3699f5cd1",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F65.webp?alt=media&token=daa304f2-2707-486e-862e-e39f5aff3c25",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F66.webp?alt=media&token=e9b4469d-a2c9-458a-ba20-e2968a4db706",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F67.webp?alt=media&token=67fb95cf-5e3b-4dbe-afa7-80dd4c85b7ce"
                   },
                   Description = "1. R.ư.ợ.u ống tre Việt 1 ống dung tích 750ml. Bộ sản phẩm đi kèm thêm búa rõ R.ư.ợ.u  và hộp đựng.\r\n2. R.ư.ợ.u  ống Tre Việt có 2 vị: 1 là vị nếp cái hoa vàng kết hợp với thảo mộc. 2 là vị R.ư.ợ.u  truyền thống\r\n3. Độ R.ư.ợ.u  lúc bơm vào cây tre là 50 độ, sau thời gian tre hấp thụ đến khi thu hoạch độ R.ư.ợ.u  còn khoảng 32 độ.\r\n4.R.ư.ợ.u  có mùi thơm do kết hợp của Tre, thảo mộc … và Vị ngọt thanh nhẹ, dễ uống.\r\n5. Cách làm R.ư.ợ.u  ống tre: R.ư.ợ.u  nếp sau khi nấu xong, cho qua máy khử các độc tố trong R.ư.ợ.u  như Metanol; Andehit. Rồi hạ thổ 1 năm với các loại hoa quả, thảo mộc hoặc dùng R.ư.ợ.u  nếp cái hoa vàng hạ thổ với các loại thảo mộc. Sau đó bơm vào cây tre đang sinh trưởng. Sau 6 tháng mới cho thu hoạch được.\r\n6. R.ư.ợ.u  dùng men bắc truyền thống, hay còn gọi là Men Trấu của các cụ ngày xưa hay nấu R.ư.ợ.u .\r\n7. Sản phẩm đã được cho đi kiểm nghiệm chuẩn chỉnh về chất lượng sản phẩm nên cực kỳ an toàn. Ngoài ra sản Phẩm R.ư.ợ.u  ống Tre Việt  đạt chứng chỉ Ocop 3 sao. Đây là sản phẩm R.ư.ợ.u  ống Tre đầu tiên ở Việt Nam đạt chứng chỉ Ocop.\r\n8. Bảo quản R.ư.ợ.u  ống Tre: Để nơi khô ráo, thoáng mát, Lúc uống muốn ngon hơn có thể để vào ngăn mát tủ lạnh.\r\n9. R.ư.ợ.u  uống ngon nhất trong 6 tháng đầu. Về sau độ R.ư.ợ.u  sẽ giảm dần, và R.ư.ợ.u  sẽ ngọt hơn",
                   UnitProduct = UnitProduct.ml,
                   Price = 80000,
                   ProductCategory = ProductCategory.Beverage,
                   CreateDate = DateTime.Now,
                   TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                   Volume = "750ml",
                   NutritionType = "Đặc sản địa phương",
                   Origin = "Việt Nam",
                   Manufacturer = "Xưởng Mộc Việt",
                   AddressManufacturer = "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị",
                   StatusApproval = StatusApproval.Approved
               },
               new Product()
               {
                   ProductId = Guid.Parse("639E1CFC-1266-4B30-9022-3927C1721AFD"),
                   ProductName = "[OCOP QUẢNG TRỊ] Bột tía tô sấy lạnh Trần Lan [Hộp 150gr]",
                   Imgs = new List<string>()
                   {
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F72.webp?alt=media&token=b0fa1e0c-85fb-455e-99c2-66578c832e4b",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F72.webp?alt=media&token=b0fa1e0c-85fb-455e-99c2-66578c832e4b",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F74.webp?alt=media&token=01e37117-b3c5-47eb-8fdd-956c7b8cfa6e",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F75.webp?alt=media&token=13fdd758-187b-44b8-9b9f-e9fb47148524",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F76.webp?alt=media&token=be498a71-dc12-42a0-bebd-844b732aa1c8",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F77.webp?alt=media&token=41f13948-a8de-49ff-88d4-a37b46dd87b8"
                   },
                   Description = "Bột lá tía tô nguyên chất được bào chế từ lá tía tô tươi, phơi khô, tán mịn để tạo thành sản phẩm bột nguyên chất, giữ được thành phần dưỡng chất bên trong \r\nPhân tích thành phần lá tía tô ta sẽ thấy : 0,3 - 0,5% tinh dầu (khối lượng khô), citral chiếm 20% khối lượng khô. Trong đó thành phần  tinh dầu chủ yếu là perillaldehyd, limonen, L-perrilla alcohol, α-pinen… \r\nLá tía tô có chứa thêm thành phần tanin và glucosid chống v.êm hiệu quả \r\n💗💗 Công dụng dưỡng da của bột lá tía tô nguyên chất Từ xưa, lá tía tô đã được biết đến với các hiệu quả làm đẹp, chăm sóc da mặt. \r\nSử dụng bột lá tía tô nguyên chất sẽ mang đến hiệu quả dưỡng da tuyệt vời mà chị em không thể qua \r\n- Hỗ trợ mụn trứng cá, mụn bọc, mụn sưng đỏ \r\n- Làm sạch da, mịn da, điều tiết dầu nhờn \r\n- Cân bằng độ ẩm cho da khô, nhờn\r\n- Khá.n.gg khuẩn, khá.n.gg v.iê.mm tốt cho làn da mẫn cảm dễ nổi mụn, da dị ứng \r\n- Da sáng dần, đều màu, trắng hồng nếu kiên trì sử dụng \r\n- Hỗ trợ trị Gout\r\n– Cảmho, đau bụng \r\n- Giảm béo, làm đẹp da \r\n- Tốt cho sức khỏe bà bầu và nhiều công dụng khác \r\n🍓🍓 Với thành phần tanin và glucosid hạn chế sự phát triển của vi khuẩn hiệu quả, ngăn ngừa các tác nhân gây mụn, giảm sưng hiệu quả \r\n➡ Lá tía tô có các hoạt chất đặc biệt hiệu quả làm tiêu các bã nhờn trên da, tích tụ gây mụn trứng cá, mụn bọc.\r\n Làm mát từ bên ngoài giúp giảm mụn tối ưu\r\n #bottiato #tiatonguyenchat #botlatiato \r\n• HSD 12 tháng sau khi mở bao bì sản phẩm \r\n• Bảo quản nơi khô ráo, thoáng mát\r\n#bot_tia_to #la_tia_to #bot_tia_to_nguyen_chat",
                   UnitProduct = UnitProduct.g,
                   Price = 80000,
                   ProductCategory = ProductCategory.HerbalMedicine,
                   CreateDate = DateTime.Now,
                   TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                   Volume = "150g",
                   Ingredient = "Tía tô, cỏ ngọt",
                   Origin = "Việt Nam",
                   Manufacturer = "Xưởng Mộc Việt",
                   AddressManufacturer = "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị",
                   StatusApproval = StatusApproval.Approved
               },
               new Product()
               {
                   ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
                   ProductName = "Nhang trầm hương cao cấp [1Kg] sạch chuẩn sản phẩm OCOP, ISO 9001 - Xưởng Mộc Việt",
                   Imgs = new List<string>()
                   {
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F82.webp?alt=media&token=b855f4ab-4b51-43ea-af26-e0deb629f97c",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F83.webp?alt=media&token=15012cad-7f6f-4cae-842c-c1e8e35d0c89",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F84.webp?alt=media&token=0576465d-964e-4ffc-93fa-54f410c761e7",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F85.webp?alt=media&token=ef5f7fbf-bf80-43d6-a4fa-ebda116b5dc1",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F86.webp?alt=media&token=521f7498-9a95-424e-884b-72b611b6f0ee"
                   },
                   Description = "THÔNG TIN SẢN PHẨM NHANG TRẦM SẠCH XƯỞNG MỘC VIỆT\r\n\r\n• Thành phần: 95% bột trầm hương tự nhiên Việt Nam, tăm tre Đài Loan cao cấp, bột vỏ cây bời lời Tây Nguyên\r\n\r\n• Trầm phổ thông: tuổi trầm khoảng từ 8-10 năm\r\n\r\n• Trầm cao cấp: tuổi trầm khoảng từ 12-15 năm\r\n\r\n• Trầm đặc biệt: tuổi trầm từ 25 năm trở lên\r\n\r\n• Số lượng cây trong 1kg: loại 40cm có khoảng 650 cây | loại 30cm có khoảng 800 cây\r\n\r\n• Độ nhang dài: 30cm | 40cm (cả cây nhang, tính từ chân đến ngọn)\r\n\r\n• Thời gian cháy: 40-50 phút với loại 30cm | 70-80 phút với loại 40cm, tuỳ vào không gian sử dụng.\r\n\r\n• Xuất xứ: Việt Nam\r\n\r\n• Cách dùng: Thắp ở bàn thờ gia tiên, bàn thờ thần tài ông địa, cúng chùa,...\r\n\r\n• Sản phẩm nhang trầm hương cao cấp được sản xuất thủ công, nguyên liệu thuần tự nhiên, mùi thơm dịu nhẹ, thơm ngọt mùi trầm. Sản phẩm để nơi khô ráo càng lâu càng thơm.\r\n\r\n\r\n\r\nHƯỚNG DẪN SỬ DỤNG NHANG TRẦM SẠCH XƯỞNG MỘC VIỆT\r\n\r\n1/ Trong thờ cúng, gia tiên:\r\n\r\n• Nhang trầm hương sạch dùng trong không gian thờ cúng, tạo sự tưởng nhớ biết ơn và cầu nguyện cho con cháu bình an, gia đình hòa thuận.\r\n\r\n• Nhang trầm hương sạch giúp thanh lọc không gian sống, tiêu trừ các loại mùi hương xấu, thu hút tài lộc.\r\n\r\n• Nhang trầm hương sạch giúp chiêu tài dẫn lộc dịp khai trương, tân gia, tất niên,..\r\n\r\n2/ Trong không gian sống và sức khoẻ:\r\n\r\n• Mùi hương trầm sạch  tạo cảm giác thư giãn, giảm áp lực, căng thẳng, cải thiện sự tập trung.\r\n\r\n• Làm thơm không gian làm việc, làm dịu nhẹ thần kinh và kích thích khả năng tư duy sáng tạo.\r\n\r\n• Nhang trầm hương sạch để xông nhà, trà đạo hoặc yoga giúp tinh thần thông thoáng, cải thiện sức khỏe.\r\n\r\n• Nhang trầm hương sạch, nguyên chất giúp cho giấc ngủ được sâu hơn, cải thiện các chứng đau đầu.\r\n\r\n\r\n\r\nCHÍNH SÁCH ĐỔI TRẢ - BẢO HÀNH\r\n\r\n1/ Đổi trả theo đúng quy định của SHOPEE:\r\n\r\n• Chỉ đổi trả khi hàng hoá còn mới, chưa qua sử dụng.\r\n\r\n• Chấp nhận đổi trả khi hàng hoá bị hỏng hoặc do lỗi của nhà sản xuất.\r\n\r\n2/ Trường hợp được chấp nhận:\r\n\r\n• Hàng không đúng phân loại, mẫu mã như quý khách đặt hàng\r\n\r\n• Không đủ số lượng, không đủ bộ như trong đơn hàng\r\n\r\n3/ Trường hợp không đủ điều kiện áp dụng chính sách:\r\n\r\n• Gửi lại hàng không đúng mẫu mã, không phải hàng của XƯỞNG MỘC VIỆT\r\n\r\n• Do màn hình và điều kiện ánh sáng khác nhau, màu sắc thực tế của sản phẩm có thể chênh lệch khoảng 3-5%.\r\n\r\n\r\n\r\nTHÔNG TIN SẢN XUẤT TRẦM HƯƠNG XƯỞNG MỘC VIỆT\r\n\r\n• Xưởng Mộc Việt là thương hiệu hàng đầu Việt Nam chuyển thu mua, sản xuất và phân phối sản phẩm vòng tay trầm hương, trang sức trầm hương, nhang trầm hương và trầm hương sạch, chuẩn tự nhiên\r\n\r\n• Sản phẩm Xưởng Mộc Việt tự hào nhận các chứng nhận như: OCOP và chuẩn sản phẩm công nghiệp nông thôn tiêu biểu tỉnh Quảng Trị\r\n\r\n• Tất cả sản phẩm được Xưởng Mộc Việt đưa ra thị trường là sản phẩm chính hãng Công ty và cam kết là hàng chuẩn trầm sạch, chuẩn tự nhiên. Được cơ quan chức năng cấp các chứng nhận: OCOP, ISO 9001:2015, VN-TEST",
                   UnitProduct = UnitProduct.Kg,
                   Price = 80000,
                   ProductCategory = ProductCategory.Orther,
                   CreateDate = DateTime.Now,
                   TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                   Volume = "1kg",
                   Ingredient = "Trầm hương, Bột Trầm Hương",
                   Origin = "Việt Nam",
                   Manufacturer = "Xưởng Mộc Việt",
                   AddressManufacturer = "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị",
                   StatusApproval = StatusApproval.Approved
               },
               new Product
               {
                   ProductId = Guid.Parse("E5C3D8D2-6FC1-41F0-A2C9-28D3DDBBFA55"),
                   ProductName = "Mứt dâu tây Mộc Châu",
                   Imgs = new List<string>
                    {
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F1.jpg?alt=media&token=b474731f-3c05-418e-ac71-9e7bd36f85d2",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F2.jpg?alt=media&token=7b48babb-d847-4333-ad7f-332c2c051698",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F3.jpg?alt=media&token=1316b40a-1b2d-4160-a798-905976414bdc"
                    },
                   Price = 95000,
                   Description = "Mứt dâu tây thủ công được làm từ những quả dâu tươi được hái tại nông trại trong tour tham quan.",
                   Additional = "Không chất bảo quản, đóng lọ thủy tinh cao cấp.",
                   NutritionType = "Vitamin C, Chất xơ",
                   Age = "Từ 3 tuổi trở lên",
                   Ingredient = "Dâu tây tươi, đường mía, nước cốt chanh",
                   Volume = "250g",
                   Origin = "Mộc Châu, Sơn La",
                   Manufacturer = "Hợp tác xã Nông sản Dâu Mộc Châu",
                   AddressManufacturer = "Bản Áng, Mộc Châu, Sơn La",
                   UnitProduct = UnitProduct.g,
                   ProductCategory = ProductCategory.Food,
                   CreateDate = DateTime.UtcNow,
                   UpdateDate = null,
                   StatusApproval = StatusApproval.Approved,
                   ReplyRequest = null,
                   TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),

               },
               new Product
               {
                   ProductId = Guid.Parse("23C7F3C2-5915-4F10-B937-6A34DA949A17"),
                   ProductName = "Sữa tươi thanh trùng Mộc Châu",
                   Imgs = new List<string>
                    {
                    "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F4.jpg?alt=media&token=cc2b259e-55e1-4ee8-bd6e-7f619a3ca9b9",
                    "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F5.jpg?alt=media&token=b4c42af8-a554-496f-933f-ee72eaa99ad7"
                    },
                   Price = 45000,
                   Description = "Sữa tươi nguyên chất, thu hoạch và chế biến trực tiếp từ trang trại bò sữa Mộc Châu.",
                   Additional = "Không đường, không chất bảo quản, giữ lạnh ở 4°C.",
                   NutritionType = "Canxi, Vitamin D, Protein",
                   Age = "Từ 1 tuổi trở lên",
                   Ingredient = "100% sữa bò tươi",
                   Volume = "1L",
                   Origin = "Mộc Châu, Sơn La",
                   Manufacturer = "Trang trại bò sữa Mộc Châu",
                   AddressManufacturer = "Dairy Farm, Mộc Châu",
                   UnitProduct = UnitProduct.ml,
                   ProductCategory = ProductCategory.Orther,
                   CreateDate = DateTime.UtcNow,
                   UpdateDate = null,
                   StatusApproval = StatusApproval.Approved,
                   ReplyRequest = null,
                   TouristFacilityId = Guid.Parse("D8C8E1D5-2CEB-413D-A5C7-342F7D2B9D63"),

               },
               new Product
               {
                   ProductId = Guid.Parse("9A8BA610-2FB7-4B75-A482-328D76DC1D18"),
                   ProductName = "Rau cải ngọt hữu cơ Mộc Châu",
                   Imgs = new List<string>
                    {
                       "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F6.jpg?alt=media&token=2579c65f-9b67-42f3-a052-3c1fc19c509f",
                       "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F7.jpg?alt=media&token=8532128f-6b27-4059-a04b-e912b62f0556",
                       "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F8.jpg?alt=media&token=d1f4592d-ea8d-42a2-b975-ef99493f8f33"
                    },
                   Price = 25000,
                   Description = "Rau cải ngọt được trồng theo phương pháp hữu cơ chuẩn OCOP tại trang trại rau Mộc Châu Xanh.",
                   Additional = "Không thuốc trừ sâu, không hóa chất, thu hoạch trong ngày.",
                   NutritionType = "Vitamin A, Vitamin C, Sắt",
                   Age = "Tất cả mọi người",
                   Ingredient = "100% rau cải ngọt hữu cơ",
                   Volume = "500g",
                   Origin = "Mộc Châu, Sơn La",
                   Manufacturer = "Trang trại rau hữu cơ Mộc Châu Xanh",
                   AddressManufacturer = "Mộc Châu Xanh, Mộc Châu",
                   UnitProduct = UnitProduct.g,
                   ProductCategory = ProductCategory.Orther,
                   CreateDate = DateTime.UtcNow,
                   UpdateDate = null,
                   StatusApproval = StatusApproval.Approved,
                   ReplyRequest = null,
                   TouristFacilityId = Guid.Parse("D8C8E1D5-2CEB-413D-A5C7-342F7D2B9D63"),

               },
               new Product
               {
                   ProductId = Guid.Parse("D56F8C35-68B1-4C42-95F5-D0E4A5D89988"),
                   ProductName = "Món ăn đặc sản Mộc Châu",
                   Imgs = new List<string>
                   {
                       "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F9.jpg?alt=media&token=fe337e6e-fe5f-43d7-8a94-622137e2dd3f",
                       "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F10.jpg?alt=media&token=2d61b4e2-0451-467a-9ca8-ef26a6cb603f",
                       "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F11.jpg?alt=media&token=28e3c536-92a5-4dd8-9dda-c70f3e8b34c0"
                   },
                   Price = 200000,
                   Description = "Bữa trưa gồm các món ăn đặc sản như bê chao, cá suối, rau rừng, và sữa chua Mộc Châu, tất cả đều làm từ nguyên liệu tươi ngon và sạch.",
                   Additional = "Các món ăn đều sử dụng nguyên liệu từ Mộc Châu, mang lại hương vị tươi ngon và đậm đà.",
                   NutritionType = "Protein, Vitamin C, Vitamin A",
                   Age = "Từ 12 tuổi trở lên",
                   Ingredient = "Bê chao, cá suối, rau rừng, sữa chua Mộc Châu",
                   Volume = "Một suất ăn",
                   Origin = "Mộc Châu, Sơn La",
                   Manufacturer = "Nhà hàng Truyền thống Bản Áng",
                   AddressManufacturer = "Bản Áng, Mộc Châu",
                   UnitProduct = UnitProduct.g,
                   ProductCategory = ProductCategory.Food,
                   CreateDate = DateTime.UtcNow,
                   UpdateDate = null,
                   StatusApproval = StatusApproval.Approved,
                   ReplyRequest = null,
                   TouristFacilityId = Guid.Parse("D8C8E1D5-2CEB-413D-A5C7-342F7D2B9D63"),
               }


           );
        }

    }
}
