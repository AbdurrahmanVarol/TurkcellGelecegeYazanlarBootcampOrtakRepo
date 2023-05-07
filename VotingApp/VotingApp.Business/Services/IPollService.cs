using VotingApp.Business.Requests;
using VotingApp.Business.Responses;
using VotingApp.Entities;

namespace VotingApp.Business.Services;
public interface IPollService {
    public Task<List<Poll>> GetJoinedPolls(int userId);
    public Task AddPoll(CreatePollRequest createPollRequest);
    public Task Update(ModifyPollRequest modifyPollRequest);
    public Task Delete(int id);
    public Task<List<PollResponse>> GetPollsByUserId(int userId);
    public Task<PollResponse> GetPollId(int id);
}