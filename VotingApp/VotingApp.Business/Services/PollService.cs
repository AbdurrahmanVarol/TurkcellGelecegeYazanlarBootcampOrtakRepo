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

    public async Task<Poll> GetByIdAsync(int id)
    {
        return await _pollRepository.GetByIdAsync(id);
    }

    public async Task<List<Poll>> GetJoinedPolls(int userId)
    {
        return await _pollRepository.GetJoinedPolls(userId);
    }
}