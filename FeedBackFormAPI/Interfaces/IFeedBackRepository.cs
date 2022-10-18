
using FeedBackForm.Models;

namespace FeedBackForm.Interfaces
{
    public interface IFeedBackRepository
    {
        ICollection<Feedback> GetFeedbacks();
        Feedback GetFeedback(int id);
        Feedback GetFeedback(string name);
        bool FeedBackExists(int id);
        bool CreateFeedBack( Feedback feedback);
        bool UpdateFeedBack(Feedback feedback);
        bool DeleteFeedBack(Feedback feedback);
        bool Save();
    }
}
