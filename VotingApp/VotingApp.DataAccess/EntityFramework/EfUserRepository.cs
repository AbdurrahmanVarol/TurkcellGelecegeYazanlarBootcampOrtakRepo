using Microsoft.EntityFrameworkCore;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework;
public sealed class EfUserRepository : EfAsyncRepositoryBase<User, VotingDbContext>, IUserRepository
{
    private readonly VotingDbContext _context;
    public EfUserRepository(VotingDbContext context) : base(context)
    {
        _context = context;
    }
    public Task<List<User>> GetParticipantByPollId(int pollId)
    {
        return (
            from user in _context.Users
            join vote in _context.Votes on user.Id equals vote.UserId
            join option in _context.Options on vote.OptionId equals option.Id
            where option.PollId == pollId
            select user
            ).ToListAsync();
    }
}