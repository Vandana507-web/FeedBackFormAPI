using FeedBackForm.Data;
using FeedBackForm.Dto;
using FeedBackForm.Interfaces;
using FeedBackForm.Models;

namespace FeedBackForm.Repository
{
    public class FeedBackRepository : IFeedBackRepository
    {
        private readonly FeedBack_DbContext _context;

        public FeedBackRepository(FeedBack_DbContext context)
        {
            _context = context;
        }

        public bool CreateFeedBack(Feedback feedback)
        {
            
            _context.Add(feedback);

            return Save();
        }

        public bool DeleteFeedBack(Feedback feedback)
        {
            _context.Remove(feedback);
            return Save();
        }

        public Feedback GetFeedback(int id)
        {
            return _context.Feedbacks.Where(p => p.Id == id).FirstOrDefault();
        }

        public Feedback GetFeedback(string name)
        {
            return _context.Feedbacks.Where(p => p.Username == name).FirstOrDefault();
        }


        public ICollection<Feedback> GetFeedbacks()
        {
            return _context.Feedbacks.OrderBy(p => p.Id).ToList();
        }

      public bool FeedBackExists(int id)
        {
            return _context.Feedbacks.Any(p => p.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateFeedBack(Feedback feedback)
        {
            _context.Update(feedback);
            return Save();
        }
    }
}
