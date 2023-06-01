using AutoMapper;
using VotingApp.Business.Dtos.Requests.PollRequests;
using VotingApp.Business.Dtos.Responses;
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
        Poll poll = new()
        {

            Title = createPollRequest.Title,
            Description = createPollRequest.Description,
            CreatedAt = DateTime.Now,
            CreatedById = createPollRequest.CreatedById,
            Options = createPollRequest.OptionNames.Select(p => new Option
            {
                Value = p,
            }).ToList()
        };
        await _pollRepository.AddAsync(poll);
        var result = await _pollRepository.SaveChangesAsync() > 0;
        return result;
    }

    public async Task<Poll> GetByIdAsync(int id)
    {
        return await _pollRepository.GetByIdAsync(id);
    }

    public async Task<List<ActivePollResponse>> GetActivePolls(int userId)
    {
        List<Poll> polls = await _pollRepository.GetActivePolls(userId);
        return _mapper.Map<List<ActivePollResponse>>(polls);
    }

    public async Task<List<PollDetailResponse>> GetJoinedPollsAsync(int userId)
    {
        var polls = await _pollRepository.GetJoinedPolls(userId);
        return _mapper.Map<List<PollDetailResponse>>(polls);
    }

    public async Task<PollResponse> GetById(int id)
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

    public async Task<List<PollResponse>> GetPollsByCreatedById(int createdById)
    {
        var polls = await _pollRepository.GetAllAsync(p => p.CreatedById == createdById && !p.IsDeleted);
        return _mapper.Map<List<PollResponse>>(polls);
    }

    public async Task Update(UpdatePollRequest updatePollRequest)
    {
        //TODO:Refactor edilecek
        var poll = await _pollRepository.GetByIdAsync(updatePollRequest.Id) ?? throw new ArgumentNullException(nameof(updatePollRequest));

        var addedOptions = updatePollRequest.Options.Where(p => p.Id == null).ToList();
        var removedOptions = poll.Options.Where(option => !updatePollRequest.Options
                                                          .Where(removedOption => removedOption.Id != null)
                                                          .Select(removedOption => removedOption.Id).Contains(option.Id)).ToList();
        poll.Title = updatePollRequest.Title;
        poll.Description = updatePollRequest.Description;

        foreach (var option in addedOptions)
        {
            poll.Options.Add(new Option
            {
                CreatedAt = DateTime.Now,
                PollId = poll.Id,
                Value = option.Value,
            });
        }
        foreach (var option in removedOptions)
        {
            poll.Options.Remove(option);
        }

        _pollRepository.Update(poll);
        await _pollRepository.SaveChangesAsync();
    }
    public async Task DeletePollById(DeletePollRequest deletePollRequest)
    {
        await _pollRepository.DeleteAsync(deletePollRequest.Id);
        await _pollRepository.SaveChangesAsync();
    }

    public async Task DeletePollAsSoftById(DeletePollRequest deletePollRequest)
    {
        var poll = await _pollRepository.GetByIdAsync(deletePollRequest.Id);
        if (poll is null)
        {
            //TODO: Hata fırlat
            return;
        }
        poll.IsDeleted = true;
        _pollRepository.Update(poll);
        await _pollRepository.SaveChangesAsync();
    }
}