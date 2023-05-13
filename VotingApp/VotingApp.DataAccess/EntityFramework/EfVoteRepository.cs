using Microsoft.EntityFrameworkCore;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;
using VotingApp.Entities.ComplexTypes;

namespace VotingApp.DataAccess.EntityFramework;
public sealed class EfVoteRepository : EfAsyncRepositoryBase<Vote, VotingDbContext>, IVoteRepository
{
    private readonly VotingDbContext _context;
    public EfVoteRepository(VotingDbContext context) : base(context)
    {
        _context = context;
    }  
    public Task<List<VoteDetail>> GetVoteDetailByPolls(int pollId)
    {
        //return _context.Votes.Include(x => x.Option)
        //    .Where(vote => vote.Option.PollId == pollId && !vote.Option.IsDeleted)
        //    .GroupBy(vote => vote.OptionId)
        //    .OrderByDescending(x => x.Count(p => !p.IsDeleted))
        //    .Select(x => new VoteDetail {
        //        Option = x.Select(a => a.Option).FirstOrDefault(),
        //        NumberOfOption = x.Count(p => !p.IsDeleted)

        //    }).ToListAsync();
        return (from vote in _context.Votes
                join option in _context.Options on vote.OptionId equals option.Id
                where option.PollId == pollId
                group new {vote,option} by new {vote.OptionId} into g
                orderby g.Count() descending
                 select new VoteDetail
                 {
                     NumberOfOption = g.Count(),
                     Option = g.Select(p=>p.option).FirstOrDefault()
                }
            ).ToListAsync();
    }

}