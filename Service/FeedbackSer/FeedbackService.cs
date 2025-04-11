using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.FeedbackSer;
using Service.Repository;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FeedbackSer
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IRepository<Feedback> _feedbackRepository;
        public FeedbackService(
          IRepository<Feedback> feedbackRepository
        )
        {
            _feedbackRepository = feedbackRepository;
        }

        public async Task<bool> AddFeedBack(Feedback feedback)
        {
            try
            {
                feedback.FeedbackId = Guid.NewGuid();
                feedback.CreateTime = DateTime.Now;
                await _feedbackRepository.AddAsync(feedback);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
                return false;
            }
        }

        public async Task<Feedback> GetFeedbackDetails(Guid FeedbackId)
        {
            try
            {
                var feedback = await _feedbackRepository.Query()
                    .Include(x => x.Account)
                    .SingleOrDefaultAsync(x => x.FeedbackId == FeedbackId);
                return feedback;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<List<Feedback>> GetListFeedbacks_Product(Guid ProductId)
        {
            try
            {
                var feedbacks = await _feedbackRepository.Query()
                    .Where(x => x.ProductId == ProductId).ToListAsync();
                return feedbacks;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<List<Feedback>> GetListFeedbacks_Tour(Guid TourId)
        {
            try
            {
                var feedbacks = await _feedbackRepository.Query()
                    .Where(x => x.TourId == TourId).ToListAsync();
                return feedbacks;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> UpdateFeedBack(Guid FeedbackId, Feedback feedback)
        {
            try
            {
                var exist = await _feedbackRepository.Query()
                            .SingleOrDefaultAsync(x => x.FeedbackId == FeedbackId);
                exist.UpdateTime = DateTime.Now;
                exist.Content = feedback.Content;
                exist.Rating = feedback.Rating;
                await _feedbackRepository.UpdateAsync(exist);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
                return false;
            }
        }
    }
}
