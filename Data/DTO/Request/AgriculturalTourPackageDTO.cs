﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class AgriculturalTourPackageRequest
    {
        public string PackageName { get; set; }
        public string? Description { get; set; }
        public List<string>? Imgs { get; set; }
        public int Slot { get; set; }
        public double PriceOfAdults { get; set; }
        public double PriceOfChildren { get; set; }
        public string? ChildTicketAge { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Durations { get; set; }
        public string? GatheringLocation { get; set; }
        public TimeType DurationsType { get; set; }
        public StatusActive? StatusActive { get; set; }
        public virtual ICollection<AgriculturalTourPackageRequest_TourGuides>? TourGuides { get; set; }
        public virtual ICollection<TourDestinationRequest>? TourDestinations { get; set; }
    }
    public class AgriculturalTourPackageRequest_TourGuides
    {
        public Guid GuideId { get; set; }
    }

}
