using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework;
public sealed class EfOptionRepository : EfAsyncRepositoryBase<Option, VotingDbContext>, IOptionRepository {
    public EfOptionRepository(VotingDbContext context) : base(context) { }
}