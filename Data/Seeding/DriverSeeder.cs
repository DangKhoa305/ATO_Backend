using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class DriverSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public DriverSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Driver>().HasData(
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                    DriverName = "Nguyễn Văn A",
                    PhoneNumber = "0987654321",
                    VehicleType = VehicleType.Car4,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    DriverName = "Trần Văn B",
                    PhoneNumber = "0978543210",
                    VehicleType = VehicleType.Car7,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000003"),
                    DriverName = "Phạm Văn C",
                    PhoneNumber = "0967452103",
                    VehicleType = VehicleType.Car16,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000004"),
                    DriverName = "Lê Thị D",
                    PhoneNumber = "0956328745",
                    VehicleType = VehicleType.Car29,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000005"),
                    DriverName = "Hoàng Văn E",
                    PhoneNumber = "0945216987",
                    VehicleType = VehicleType.Car45,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000006"),
                    DriverName = "Đỗ Thị F",
                    PhoneNumber = "0934125698",
                    VehicleType = VehicleType.SleeperBusSingle,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000007"),
                    DriverName = "Ngô Văn G",
                    PhoneNumber = "0923546987",
                    VehicleType = VehicleType.SleeperBusCouple,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000008"),
                    DriverName = "Bùi Văn H",
                    PhoneNumber = "0912564873",
                    VehicleType = VehicleType.Fly,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000009"),
                    DriverName = "Vũ Thị I",
                    PhoneNumber = "0901254789",
                    VehicleType = VehicleType.Car4,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000010"),
                    DriverName = "Dương Văn J",
                    PhoneNumber = "0896541237",
                    VehicleType = VehicleType.Car7,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000011"),
                    DriverName = "Phan Thị K",
                    PhoneNumber = "0889652314",
                    VehicleType = VehicleType.Car16,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000012"),
                    DriverName = "Lý Văn L",
                    PhoneNumber = "0871236549",
                    VehicleType = VehicleType.Car29,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000013"),
                    DriverName = "Trịnh Văn M",
                    PhoneNumber = "0867412365",
                    VehicleType = VehicleType.Car45,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000014"),
                    DriverName = "Nguyễn Thị N",
                    PhoneNumber = "0859632147",
                    VehicleType = VehicleType.SleeperBusSingle,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000015"),
                    DriverName = "Lê Văn O",
                    PhoneNumber = "0847125639",
                    VehicleType = VehicleType.SleeperBusCouple,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000016"),
                    DriverName = "Võ Văn P",
                    PhoneNumber = "0836547891",
                    VehicleType = VehicleType.Fly,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Driver
                {
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000017"),
                    DriverName = "Trần Văn Q",
                    PhoneNumber = "0825478963",
                    VehicleType = VehicleType.Car4,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media&token=230f0598-5950-42b2-be2b-8bf65ac29074" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                }
            );
        }
    }
}