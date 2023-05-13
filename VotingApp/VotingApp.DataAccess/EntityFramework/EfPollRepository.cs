using Microsoft.EntityFrameworkCore;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework;
public sealed class EfPollRepository : EfAsyncRepositoryBase<Poll, VotingDbContext>, IPollRepository
{
    private readonly VotingDbContext _context;
    public EfPollRepository(VotingDbContext context) : base(context)
    {
        _context = context;
    }
    public Task<List<Poll>> GetJoinedPolls(int userId)
    {
        return (from vote in _context.Votes
                join option in _context.Options on vote.OptionId equals option.Id
                join poll in _context.Polls on option.PollId equals poll.Id
                where vote.UserId == userId
                select poll
            ).ToListAsync();
    }
}