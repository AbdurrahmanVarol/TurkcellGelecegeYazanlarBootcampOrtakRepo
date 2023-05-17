using Microsoft.EntityFrameworkCore;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;
using VotingApp.Entities.ComplexTypes;

namespace VotingApp.DataAccess.EntityFramework;
public sealed class EfPollRepository : EfAsyncRepositoryBase<Poll, VotingDbContext>, IPollRepository
{
    private readonly VotingDbContext _context;
    public EfPollRepository(VotingDbContext context) : base(context)
    {
        _context = context;
    }
    public Task<List<PollDetail>> GetJoinedPolls(int userId)
    {
        return (from vote in _context.Votes
                join option in _context.Options on vote.OptionId equals option.Id
                join poll in _context.Polls on option.PollId equals poll.Id
                where vote.UserId == userId
                orderby poll.CreatedAt descending
                select new PollDetail
                {
                    Poll = poll,
                    NumberOfParticipant = (
                                           from user in _context.Users
                                           join vote in _context.Votes on user.Id equals vote.UserId
                                           join option in _context.Options on vote.OptionId equals option.Id
                                           where option.PollId == poll.Id
                                           select user
                                           ).Count()
                }
               ).ToListAsync();
    }

    public async Task<List<Poll>> GetPollsWithOption() {
        return await _context.Polls.Include(poll => poll.Options).ToListAsync();
    }
}