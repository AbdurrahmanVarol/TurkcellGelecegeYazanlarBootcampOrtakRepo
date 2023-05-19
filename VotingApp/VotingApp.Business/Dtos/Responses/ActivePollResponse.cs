namespace VotingApp.Business.Dtos.Responses;
public sealed class ActivePollResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<ActivePollOption> Options { get; set; }
}

public sealed class ActivePollOption
{
    public int Id { get; set; }
    public string Value { get; set; }
}