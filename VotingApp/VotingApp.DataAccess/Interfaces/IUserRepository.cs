using VotingApp.Entities;

namespace VotingApp.DataAccess.Interfaces;
public interface IUserRepository : IAsyncRepository<User>
{
    Task<List<User>> GetParticipantByPollId(int pollId);
}