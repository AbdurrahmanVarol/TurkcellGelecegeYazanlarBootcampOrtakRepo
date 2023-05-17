using VotingApp.Entities;
using VotingApp.Entities.ComplexTypes;

namespace VotingApp.DataAccess.Interfaces;
public interface IPollRepository : IAsyncRepository<Poll>
{
    Task<List<PollDetail>> GetJoinedPolls(int userId);
    public Task<List<Poll>> GetPollsWithOption();
}