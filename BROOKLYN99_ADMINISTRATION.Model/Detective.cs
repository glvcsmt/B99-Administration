namespace BROOKLYN99_ADMINISTRATION.Model;

public class Detective
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Rank  { get; set; }
    public DateTime StartOfCareer { get; set; }

    public Detective(string id, string name, string rank, DateTime startOfCareer)
    {
        Id = id;
        Name = name;
        Rank = rank;
        StartOfCareer = startOfCareer;
    }
}