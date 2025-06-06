﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AgriculturalTourPackageSer
{
    public interface IAgriculturalTourPackageService
    {
        Task<List<AgriculturalTourPackage>> GetListAgriculturalTourPackages(Guid UserId);
        Task<AgriculturalTourPackage> GetAgriculturalTourPackage(Guid TourId);
        Task<TourDestination> GetTourDestination(Guid TourDestinationId);
        Task<bool> CreateAgriculturalTourPackage(AgriculturalTourPackage newTour, Guid UserId);
        Task<bool> UpdateAgriculturalTourPackage(Guid TourId, AgriculturalTourPackage updatedTour);
        Task<bool> CreateTourDestination(TourDestination newTourDestination, Guid TourId);
        Task<bool> UpdateTourDestination(Guid TourDestinationId, TourDestination updatedTourDestination);
        Task<List<AgriculturalTourPackage>> GetListAgriculturalTourPackages_Guest();
        Task<List<AgriculturalTourPackage>> GetAll();
        Task<AgriculturalTourPackage> GetAgriculturalTourPackage_Guest(Guid TourId);
        Task<bool> ProcessApproval(Guid id, StatusApproval status);
        Task<int> GetPeople(Guid tourId);

        Task<List<AgriculturalTourPackage>> GetAllByTourGuideAsync(Guid UserId);
        Task AddTourGuides(List<Guid>? tourGuideIds, Guid tourId);
        Task AddTourDestinations(ICollection<TourDestination>? destinations, Guid tourId);

    }
}
