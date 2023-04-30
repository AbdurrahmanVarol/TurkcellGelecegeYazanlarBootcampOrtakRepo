using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework;
public sealed class EfUserRepository : EfAsyncRepositoryBase<User, VotingDbContext>, IUserRepository {
    public EfUserRepository(VotingDbContext context) : base(context) { }
}