using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Requests;
using VotingApp.Business.Responses;
using VotingApp.Entities;
using VotingApp.Entities.ComplexTypes;

namespace VotingApp.Business.Services
{
    public interface IVoteService
    {
        Task<List<VoteResponse>> GetVotesAsync();
        Task<VoteResponse> GetVoteByIdAsync(int id);
        Task<VoteResponse> AddAsync(CreateVoteRequest createVoteRequest);
        Task<VoteResponse> UpdateAsync(UpdateVoteRequest updateVoteRequest);
        Task DeleteAsync(int id);
        Task<List<VoteDetail>> GetVoteDetailByPolls(int pollId);
        Task<VoteReportResponse> GetVoteReportByPollId(int id);
    }
}
