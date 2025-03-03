using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Service.PageResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.UserSupportSer
{
    public interface IUserSupportService
    {
        Task<ResponseVM> RequestUserSupport(UserSupport userSupport);
        Task<ResponseVM> ReplyRequestUserSupport(ReplyUserSupportRequest userSupport);
        //Task<PagedResult<UserSupport>> ListUserSupport(string? search, bool? IsResolved, IssueType? issueType, int page, int pageSize);
        Task<List<UserSupport>> ListUserSupport();
        Task<UserSupport> UserSupportDetails(Guid SupportId);
    }
}
