using VotingApp.Entities;

namespace VotingApp.Business.Services;
public interface IPollService
{
    Task<List<Poll>> GetJoinedPolls(int userId);
}