using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework;
public sealed class EfPollRepository : EfAsyncRepositoryBase<Poll, VotingDbContext>, IPollRepository {
    public EfPollRepository(VotingDbContext context) : base(context) { }
}