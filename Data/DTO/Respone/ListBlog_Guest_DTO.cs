using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class ListBlog_Guest_DTO
    {
        public Guid BlogId { get; set; }
        public string Title { get; set; }
        public string LinkImg { get; set; }
        public string Description { get; set; }
        public string CreateByName { get; set; }
        public Guid? TourCompanyId { get; set; }
        public Guid? TouristFacilityId { get; set; }
        public BlogType BlogType { get; set; }
        public DateTime CreateDate { get; set; }
        public string DescriptionAPI { get; set; } = "BlogType( 0-Sự kiện, 1-Tin tức )";
    }
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
}
