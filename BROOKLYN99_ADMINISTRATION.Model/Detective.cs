using System.ComponentModel.DataAnnotations;

namespace BROOKLYN99_ADMINISTRATION.Model;

public class Detective
{
    [Key]
    [Required]
    public string Id { get; set; }
    
    [StringLength(50)]
    [Required]
    public string Name { get; set; }
    
    [StringLength(50)]
    [Required]
    public string Rank  { get; set; }
    
    [Required]
    public DateTime StartOfCareer { get; set; }
    
    public ICollection<Case> Cases { get; set; }

    public Detective(string id, string name, string rank, DateTime startOfCareer)
    {
        Id = id;
        Name = name;
        Rank = rank;
        StartOfCareer = startOfCareer;
    }
}