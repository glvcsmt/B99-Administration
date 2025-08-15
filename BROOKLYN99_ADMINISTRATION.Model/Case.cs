using System.ComponentModel.DataAnnotations;

namespace BROOKLYN99_ADMINISTRATION.Model;

public enum Status
{
    UnderInvestigation = 0,
    OnHold = 1,
    Closed = 2
}

public class Case
{
    [Key]
    [Required]
    public string Id { get; set; }
    
    [StringLength(50)]
    [Required]
    public string Title { get; set; }
    
    [StringLength(1500)]
    [Required]
    public string Description { get; set; }
    
    [Required]
    public Status Status { get; set; }
    
    [Required]
    public DateTime StartOfInvestigation { get; set; }
    
    [Required]
    public DateTime EndOfInvestigation { get; set; }
    
    [Required]
    public List<String> Suspects { get; set; }
    
    [Required]
    public List<String> Victims { get; set; }
    
    [Required]
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