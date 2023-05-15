using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Requests;
using VotingApp.Business.Responses;
using VotingApp.DataAccess.EntityFramework;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;
using VotingApp.Entities.ComplexTypes;

namespace VotingApp.Business.Services
{
    public class VoteService : IVoteService
    {
        private readonly IVoteRepository _voteRepository;
        private readonly IUserService _userService;
        private readonly IPollService _pollService;
        private readonly IMapper _mapper;

        public VoteService(IVoteRepository voteRepository, IUserService userService, IPollService pollService, IMapper mapper)
        {
            _voteRepository = voteRepository;
            _userService = userService;
            _pollService = pollService;
            _mapper = mapper;
        }


        public async Task<VoteResponse> AddAsync(CreateVoteRequest createVoteRequest)
        {
            var vote = _mapper.Map<Vote>(createVoteRequest);
            await _voteRepository.AddAsync(vote);
            await _voteRepository.SaveChangesAsync();
            return _mapper.Map<VoteResponse>(vote);
        }

        public async Task DeleteAsync(int id)
        {
            await _voteRepository.DeleteAsync(id);
        }
        public async Task<VoteResponse> GetVoteByIdAsync(int id)
        {
            var vote = await _voteRepository.GetByIdAsync(id);
            //TODO: null check?
            return _mapper.Map<VoteResponse>(vote);

        }

        public Task<List<VoteDetail>> GetVoteDetailByPolls(int pollId)
        {
            return _voteRepository.GetVoteDetailByPolls(pollId);
        }

        public async Task<VoteReportResponse> GetVoteReportByPollId(int id)
        {
            var participants = await _userService.GetParticipantByPollId(id);
            var poll = await _pollService.GetByIdAsync(id);
            var voteDetails = await _voteRepository.GetVoteDetailByPolls(id);

            var report = new VoteReportResponse
            {
                Participants = _mapper.Map<List<UserResponse>>(participants),
                Poll = _mapper.Map<PollResponse>(poll),
                VoteDetails = voteDetails
            };
            return report;
        }

        public async Task<List<VoteResponse>> GetVotesAsync()
        {
            var votes = await _voteRepository.GetAllAsync();
            return _mapper.Map<List<VoteResponse>>(votes);
        }

        public async Task<List<VoteResponse>> GetVotesByUserIdAsync(int userId)
        {
            var votes = await _voteRepository.GetAllAsync(p => p.UserId == userId, false);
            return _mapper.Map<List<VoteResponse>>(votes);
        }

        public async Task<VoteResponse> UpdateAsync(UpdateVoteRequest updateVoteRequest)
        {
            var hasVote = await _voteRepository.GetByIdAsync(updateVoteRequest.Id) == null;
            if (hasVote)
            {
                throw new ArgumentException(nameof(updateVoteRequest));
            }
            var vote = _mapper.Map<Vote>(updateVoteRequest);
            _voteRepository.Update(vote);
            await _voteRepository.SaveChangesAsync();
            return _mapper.Map<VoteResponse>(vote);
        }
    }
}
