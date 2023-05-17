namespace VotingApp.Business.Responses;
public sealed class ActivePollResponse {
    public Int32 Id { get; set; }
    public String Title { get; set; }
    public String Description { get; set; }
    public List<ActivePollOption> Options { get; set; }
}

public sealed class ActivePollOption {
    public Int32 Id { get; set; }
    public String Value { get; set; }
}