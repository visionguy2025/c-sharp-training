namespace Models;

public sealed record ConfidentialProject:Project
{
    public int SecurityLevel {get; set;}
};
