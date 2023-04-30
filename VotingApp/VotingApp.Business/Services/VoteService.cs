using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Requests;
using VotingApp.Business.Responses;

namespace VotingApp.Business.Services
{
    public class VoteService : IVoteService
    {
        //TODO: DataAccess yazıldıktan sonra doldurulacka
        public Task<VoteResponse> AddAsync(CreateVoteRequest createVoteRequest)
        {
            throw new NotImplementedException();
        }

        public Task<VoteResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VoteResponse> GetVoteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VoteReportResponse> GetVoteReportByPollId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VoteResponse>> GetVotesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<VoteResponse>> GetVotesByPollIdAsync(int pollId)
        {
            throw new NotImplementedException();
        }

        public Task<List<VoteResponse>> GetVotesByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<VoteResponse> UpdateAsync(ModifyVoteRequest modifyVoteRequest)
        {
            throw new NotImplementedException();
        }
    }
}
