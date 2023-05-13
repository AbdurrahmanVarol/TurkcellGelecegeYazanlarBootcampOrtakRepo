using System.Threading.Tasks;
using VotingApp.Business.Requests;
using VotingApp.Business.Responses;
using VotingApp.Entities;

namespace VotingApp.Business.Services;
public interface IPollService
{
    Task<Poll> GetByIdAsync(int id);
    Task<List<Poll>> GetJoinedPolls(int userId);
    Task<bool> CreatePollAsync(CreatePollRequest createPollRequest);
}