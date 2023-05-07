using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Requests;
using VotingApp.Business.Responses;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;
using VotingApp.Entities.ComplexTypes;

namespace VotingApp.Business.Services
{
    public class VoteService : IVoteService
    {
        private readonly IVoteRepository _voteRepository;
        private readonly IUserRepository _userRepository;
        private readonly IPollRepository _pollRepository;

        public VoteService(IVoteRepository voteRepository, IUserRepository userRepository, IPollRepository pollRepository)
        {
            _voteRepository = voteRepository;
            _userRepository = userRepository;
            _pollRepository = pollRepository;
        }

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

        public Task<List<VoteDetail>> GetVoteDetailByPolls(int pollId)
        {
            return _voteRepository.GetVoteDetailByPolls(pollId);
        }

        public async Task<VoteReportResponse> GetVoteReportByPollId(int id)
        {
            //TODO: AutoMapper Eklenecek
            var participants = await _userRepository.GetParticipantByPollId(id);
            var poll = await _pollRepository.GetAsync(p => p.Id == id);
            var voteDetails = await _voteRepository.GetVoteDetailByPolls(id);
            var report = new VoteReportResponse
            {
                Participants = participants.Select(p => new UserResponse
                {
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Email = p.Email,
                    UserName = p.UserName
                }).ToList(),
                Poll = new PollResponse
                {
                    Description = poll.Description,
                    Title = poll.Title
                },
                VoteDetails = voteDetails
            };
            return report;
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
