using VotingApp.Entities;
using VotingApp.Entities.ComplexTypes;

namespace VotingApp.DataAccess.Interfaces;
public interface IVoteRepository : IAsyncRepository<Vote>
{   
    Task<List<VoteDetail>> GetVoteDetailByPolls(int pollId);
}