using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class TourGuideSeeder
    {

        private readonly ModelBuilder modelBuilder;

        public TourGuideSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            //Seed TourGuide
            modelBuilder.Entity<TourGuide>().HasData(
                 new TourGuide
                 {
                     GuideId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                     TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                     UserId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                     Bio = "Expert in eco-tourism with 5 years of experience.",
                     Languages = "English, French",
                     ExpertiseArea = "Eco-farming, fruit orchards",
                     Rating = 4.8,
                     CreateDate = DateTime.UtcNow,
                     UpdateDate = null
                 },
                new TourGuide
                {
                    GuideId = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    UserId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    Bio = "Specialist in sustainable agriculture tours.",
                    Languages = "English, Spanish",
                    ExpertiseArea = "Tea plantations, organic farming",
                    Rating = 4.6,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = DateTime.UtcNow
                },
                new TourGuide
                {
                    GuideId = Guid.Parse("10000000-0000-0000-0000-000000000003"),
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    UserId = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                    Bio = "Guided over 200 eco-tours with top reviews.",
                    Languages = "English, Vietnamese",
                    ExpertiseArea = "Mountain trekking, herbal farming",
                    Rating = 4.9,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null
                },
                new TourGuide
                {
                    GuideId = Guid.Parse("10000000-0000-0000-0000-000000000004"),
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    UserId = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                    Bio = "Passionate about agritourism and cultural exchange.",
                    Languages = "English, German",
                    ExpertiseArea = "Coffee plantations, farm stays",
                    Rating = 4.7,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null
                },
                new TourGuide
                {
                    GuideId = Guid.Parse("10000000-0000-0000-0000-000000000005"),
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    UserId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    Bio = "10 years of experience in eco-tourism industry.",
                    Languages = "English, Chinese",
                    ExpertiseArea = "Rice farming, eco-tourism",
                    Rating = 4.5,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null
                },
                new TourGuide
                {
                    GuideId = Guid.Parse("10000000-0000-0000-0000-000000000006"),
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    UserId = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                    Bio = "An expert in organic farming and sustainable tourism.",
                    Languages = "English, Korean",
                    ExpertiseArea = "Tea plantations, eco-farms",
                    Rating = 4.8,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = DateTime.UtcNow
                },
                new TourGuide
                {
                    GuideId = Guid.Parse("10000000-0000-0000-0000-000000000007"),
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    UserId = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                    Bio = "Combining tourism and local culture for unique experiences.",
                    Languages = "English, Japanese",
                    ExpertiseArea = "Cultural farming, organic coffee",
                    Rating = 4.6,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null
                },
                new TourGuide
                {
                    GuideId = Guid.Parse("10000000-0000-0000-0000-000000000008"),
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    UserId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD"),
                    Bio = "Bringing sustainable travel to the next level.",
                    Languages = "English, Thai",
                    ExpertiseArea = "Tropical fruit farms, eco-friendly tours",
                    Rating = 4.7,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = DateTime.UtcNow
                },
                new TourGuide
                {
                    GuideId = Guid.Parse("10000000-0000-0000-0000-000000000009"),
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    UserId = Guid.Parse("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                    Bio = "Guiding farm tours with an educational approach.",
                    Languages = "English, Portuguese",
                    ExpertiseArea = "Dairy farming, vineyard tours",
                    Rating = 4.5,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null
                },
                new TourGuide
                {
                    GuideId = Guid.Parse("10000000-0000-0000-0000-000000000010"),
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    UserId = Guid.Parse("64454A5E-9883-4548-9A9D-D7986BF6B3AD"),
                    Bio = "Committed to authentic rural tourism experiences.",
                    Languages = "English, Italian",
                    ExpertiseArea = "Olive farming, agritourism",
                    Rating = 4.9,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = DateTime.UtcNow
                }
            );
        }
    }
}
