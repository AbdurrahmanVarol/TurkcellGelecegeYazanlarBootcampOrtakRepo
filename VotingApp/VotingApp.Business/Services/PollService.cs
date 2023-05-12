using VotingApp.Business.Requests;
using VotingApp.Business.Responses;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;

namespace VotingApp.Business.Services;
public sealed class PollService : IPollService
{
    private readonly IPollRepository _pollRepository;

    public PollService(IPollRepository pollRepository)
    {
        _pollRepository = pollRepository;
    }

    public Task<Poll> GetByIdAsync(int id)
    {
        return _pollRepository.GetByIdAsync(id);
    }

    public Task<List<Poll>> GetJoinedPolls(int userId)
    {
        return _pollRepository.GetJoinedPolls(userId);
    }

    public Task<PollResponse> GetPollId(Int32 id) {
        throw new NotImplementedException();
    }

    public Task<List<PollResponse>> GetPollsByUserId(Int32 userId) {
        throw new NotImplementedException();
    }

    public void Update(Poll poll) {
        _pollRepository.Update(poll);
    }

    public Task Update(ModifyPollRequest modifyPollRequest) {
        throw new NotImplementedException();
    }
}