namespace Models;

public record Project
{
    public int Id {get; set;}
    public string Name {get; set;}
    public string StartDate {get; set;}
    public string EndDate {get; set;}
    public string Status {get; set;}
};
