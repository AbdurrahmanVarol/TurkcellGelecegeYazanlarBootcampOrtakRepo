using System.Threading.Tasks;
using VotingApp.Business.Dtos.Requests.PollRequests;
using VotingApp.Business.Dtos.Responses;
using VotingApp.Entities;

namespace VotingApp.Business.Services;
public interface IPollService
{
    public Task<Poll> GetByIdAsync(int id);
    public Task<List<PollDetailResponse>> GetJoinedPollsAsync(int userId);
    public Task<bool> CreatePollAsync(CreatePollRequest createPollRequest);
    public Task<PollResponse> GetById(int id);
    public Task<List<PollResponse>> GetPollsByUserId(int userId);
    Task<List<PollResponse>> GetPollsByCreatedById(int createdById);
    public Task Update(UpdatePollRequest updatePollRequest);
    public Task Delete(int id);
    public Task<List<ActivePollResponse>> GetActivePolls();
}