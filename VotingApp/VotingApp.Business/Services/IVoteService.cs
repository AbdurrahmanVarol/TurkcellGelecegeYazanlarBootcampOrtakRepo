using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Requests;
using VotingApp.Business.Responses;

namespace VotingApp.Business.Services
{
    public interface IVoteService
    {
        Task<List<VoteResponse>> GetVotesAsync();
        Task<List<VoteResponse>> GetVotesByUserIdAsync(int userId);
        Task<VoteResponse> GetVotesByIdAsync(int id);
        Task<VoteReportResponse> GetVoteReportById(int id);
        Task<VoteResponse> AddAsync(CreateVoteRequest createVoteRequest);
        Task<VoteResponse> UpdateAsync(ModifyVoteRequest modifyVoteRequest);
        Task<VoteResponse> DeleteAsync(int id);
    }
}
