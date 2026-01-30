using Microsoft.EntityFrameworkCore;

namespace Models;

public class AppDBContext : DbContext
{
    public DBSet<Developer> Developers => Set<Developer>();

    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
        var options = new DBContextOptionsBuilder<AppDBContext>()
            .UseSQLServer(@"Server=(localdb)\MSSQLLocalDB;Database=TestDb;Trusted_Connection=True;")
            .Options;
        
        using var context = new AppDBContext(options);
    }
}
