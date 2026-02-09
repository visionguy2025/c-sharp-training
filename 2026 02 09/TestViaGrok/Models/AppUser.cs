namespace AuthDemo.Models;

public class AppUser
{
    public Guid Id {get; set;} = Guid.NewGuid();
    public string Email {get; set;} = string.Empty;
    public string FullName {get; set;} = string.Empty;
    public string PasswordHash {get; set;} = string.Empty;
    public List<string> Roles {get; set;} = new() {"User"};
}
