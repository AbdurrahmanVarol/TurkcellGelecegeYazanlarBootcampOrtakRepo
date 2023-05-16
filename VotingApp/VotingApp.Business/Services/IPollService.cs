using System.Threading.Tasks;
using VotingApp.Business.Requests;
using VotingApp.Business.Responses;
using VotingApp.Entities;

namespace VotingApp.Business.Services;
public interface IPollService {
    public Task<Poll> GetByIdAsync(int id);
    public Task<List<PollDetailResponse>> GetJoinedPollsAsync(int userId);
    public Task<bool> CreatePollAsync(CreatePollRequest createPollRequest);
    public Task<PollResponse> GetById(int id);
    public Task<List<PollResponse>> GetPollsByUserId(int userId);
    public Task Update(Poll poll);
    public Task Delete(int id);
}