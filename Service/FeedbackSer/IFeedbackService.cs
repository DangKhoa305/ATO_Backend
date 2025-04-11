using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FeedbackSer
{
    public interface IFeedbackService
    {
        Task<List<Feedback>> GetListFeedbacks_Product(Guid ProductId);
        Task<List<Feedback>> GetListFeedbacks_Tour(Guid TourId);
        Task<Feedback> GetFeedbackDetails(Guid FeedbackId);
        Task<bool> AddFeedBack(Feedback feedback);
        Task<bool> UpdateFeedBack(Guid FeedbackId, Feedback feedback);
    }
}
