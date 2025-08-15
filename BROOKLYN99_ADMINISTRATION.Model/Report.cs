using System.ComponentModel.DataAnnotations;

namespace BROOKLYN99_ADMINISTRATION.Model;

public class Report
{
    [Key]
    public string Id { get; set; }
    
    [Required]
    public DateTime DateOfCreation { get; set; }
    
    [StringLength(10000)]
    [Required]
    public string Content { get; set; }

    public Report(string id, DateTime dateOfCreation, string content)
    {
        Id = id;
        DateOfCreation = dateOfCreation;
        Content = content;
    }
}