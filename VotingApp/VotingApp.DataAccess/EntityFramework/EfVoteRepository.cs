using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework;
public sealed class EfVoteRepository : EfAsyncRepositoryBase<Vote, VotingDbContext>, IVoteRepository {
    public EfVoteRepository(VotingDbContext context) : base(context) { }
}