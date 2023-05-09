using VotingApp.Entities;

namespace VotingApp.Business.Services;
public interface IPollService
{
    Task<Poll> GetByIdAsync(int id);
    Task<List<Poll>> GetJoinedPolls(int userId);
}