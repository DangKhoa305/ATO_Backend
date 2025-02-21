using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Nest;
using Service.EmailSer;
using Service.PageResult;
using Service.Repository;
using Service.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AboutSer
{
    public class AboutService : IAboutService
    {
        private readonly Service.Repository.IRepository<About> _aboutRepository;
        public AboutService(
           Service.Repository.IRepository<About> aboutRepository
        )
        {
            _aboutRepository = aboutRepository;
        }
        public async Task<About> GetAbout()
        {
            try
            {
                return await _aboutRepository.Query()
                .FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
            
        }
    }
}
