using VotingApp.Business.Responses;

namespace VotingApp.MVC.Models
{
    public class PollViewModel
    {
        public UserResponse User { get; set; }
        public List<PollDetailResponse> Polls { get; set; }
    }
}
