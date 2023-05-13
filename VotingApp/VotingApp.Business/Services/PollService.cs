﻿using AutoMapper;
using VotingApp.Business.Requests;
using VotingApp.Business.Responses;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;

namespace VotingApp.Business.Services;
public sealed class PollService : IPollService
{
    private readonly IPollRepository _pollRepository;
    private readonly IMapper _mapper;

    public PollService(IPollRepository pollRepository, IMapper mapper)
    {
        _pollRepository = pollRepository;
        _mapper = mapper;
    }

    public async Task<bool> CreatePollAsync(CreatePollRequest createPollRequest)
    {
        var poll = new Poll
        {

            Title = createPollRequest.Title,
            Description = createPollRequest.Description,
            CreatedAt = DateTime.Now,
            CreatedById = 1,
            Options = createPollRequest.OptionNames.Select(p => new Option
            {
                Value = p,
            }).ToList()
        };
        await _pollRepository.AddAsync(poll);

        return await _pollRepository.SaveChangesAsync() > 0;
    }

    public async Task<Poll> GetByIdAsync(int id)
    {
        return await _pollRepository.GetByIdAsync(id);
    }

    public Task<List<Poll>> GetJoinedPolls(int userId)
    {
        return _pollRepository.GetJoinedPolls(userId);
    }

    public async Task<PollResponse> GetPollId(int id)
    {
        Poll poll = await _pollRepository.GetByIdAsync(id);
        ArgumentNullException.ThrowIfNull(poll);
        return _mapper.Map<PollResponse>(poll);
    }

    public async Task<List<PollResponse>> GetPollsByUserId(int userId)
    {
        List<Poll> polls = await _pollRepository.GetAllAsync(poll => poll.CreatedById == userId, false);
        return _mapper.Map<List<PollResponse>>(polls);
    }

    public void Update(Poll poll)
    {
        _pollRepository.Update(poll);
    }

    public Task Update(ModifyPollRequest modifyPollRequest)
    {
        throw new NotImplementedException();
    }
}