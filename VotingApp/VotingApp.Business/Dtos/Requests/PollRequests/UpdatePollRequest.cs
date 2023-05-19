using VotingApp.Business.Dtos.Requests.OptionRequests;

namespace VotingApp.Business.Dtos.Requests.PollRequests
{
    public class UpdatePollRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<CreateOptionRequest> Options { get; set; }
    }
}