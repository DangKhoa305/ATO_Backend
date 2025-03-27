//using Data.Models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Data.Seeding
//{
//    public class OCOPProductActivitySeeder
//    {
//        private readonly ModelBuilder modelBuilder;

//        public OCOPProductActivitySeeder(ModelBuilder modelBuilder)
//        {
//            this.modelBuilder = modelBuilder;
//        }
//        public void Seed()
//        {
//            //Seed OCOPProductActivity
//            modelBuilder.Entity<OCOPProductActivity>().HasData(

//                new OCOPProductActivity()
//                {
//                    ActivityId = Guid.Parse("694FCE72-18EB-44D0-97E5-FD2CA2840C96"),
//                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
//                },
//                new OCOPProductActivity()
//                {
//                    ActivityId = Guid.Parse("6723A17D-AE68-478E-9667-D2E62CB0AEBA"),
//                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
//                },
//                new OCOPProductActivity()
//                {
//                    ActivityId = Guid.Parse("06F562CF-B39E-428F-921E-8FC94826505E"),
//                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
//                },
//                new OCOPProductActivity()
//                {
//                    ActivityId = Guid.Parse("26DC3636-9823-4900-AD4D-7AB5F408CBBA"),
//                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
//                },
//                new OCOPProductActivity()
//                {
//                    ActivityId = Guid.Parse("C0FE9C22-A634-48F1-9847-279C95F9C483"),
//                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
//                },
//                new OCOPProductActivity()
//                {
//                    ActivityId = Guid.Parse("CDA718C5-68F0-49ED-A33A-3B564182031E"),
//                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
//                }
//            );
//        }
//    }
//}
