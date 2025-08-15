namespace BROOKLYN99_ADMINISTRATION.Model;

public class Report
{
    public string Id { get; set; }
    public DateTime DateOfCreation { get; set; }
    public string Content { get; set; }

    public Report(string id, DateTime dateOfCreation, string content)
    {
        Id = id;
        DateOfCreation = dateOfCreation;
        Content = content;
    }
}