using Data.Models;
using Service.PageResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AboutSer
{
    public interface IAboutService
    {
        Task<About> GetAbout();
    }
}
