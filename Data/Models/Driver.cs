using Data.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Driver
    {
        public Guid DriverId { get; set; }
        public string DriverName { get; set; }
        public string PhoneNumber { get; set; }
        public VehicleType VehicleType { get; set; }
        public List<string>? Imgs { get; set; }
        public Guid TourCompanyId { get; set; }
        public virtual TourCompany? TourCompany { get; set; }
        public virtual ICollection<TourDestination>? TourDestinations { get; set; }
    }
    public enum VehicleType
    {
        Car4,
        Car7,
        Car16,
        Car29,
        Car45,
        SleeperBusSingle,
        SleeperBusCouple,
        Fly
    }
}
