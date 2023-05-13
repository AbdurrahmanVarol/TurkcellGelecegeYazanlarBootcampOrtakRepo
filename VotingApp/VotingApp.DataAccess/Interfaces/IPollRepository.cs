using VotingApp.Entities;

namespace VotingApp.DataAccess.Interfaces;
public interface IPollRepository : IAsyncRepository<Poll>
{
    Task<List<Poll>> GetJoinedPolls(int userId);
}