namespace BROOKLYN99_ADMINISTRATION.Model;

public enum Status
{
    UnderInvestigation = 0,
    OnHold = 1,
    Closed = 2
}

public class Case
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
    public DateTime StartOfInvestigation { get; set; }
    public DateTime EndOfInvestigation { get; set; }
    public List<String> Suspects { get; set; }
    public List<String> Victims { get; set; }
    public List<string> Evidences { get; set; }
    
    public ICollection<Report> Reports { get; set; }

    public Case(string id, string title, string description, Status status, DateTime startOfInvestigation, DateTime endOfInvestigation, List<string> suspects, List<string> victims, List<string> evidences)
    {
        Id = id;
        Title = title;
        Description = description;
        Status = status;
        StartOfInvestigation = startOfInvestigation;
        EndOfInvestigation = endOfInvestigation;
        Suspects = suspects;
        Victims = victims;
        Evidences = evidences;
    }
}