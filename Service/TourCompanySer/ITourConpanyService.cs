using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TourCompanySer
{
    public interface ITourCompanyService
    {
        Task<List<TourCompany>> GetListTourCompanies_Admin();
        Task<TourCompany> GetTourCompany_Admin(Guid TourCompanyId);
    }
}
