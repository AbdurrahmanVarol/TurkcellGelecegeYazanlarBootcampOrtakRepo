using VotingApp.Entities;

namespace VotingApp.DataAccess.Interfaces;
public interface IVoteRepository : IAsyncRepository<Vote> { }