namespace DataAccessLayer;

public class EFDbContext:DbContext
{
    public EFDbContext(DbContextOptions<EFDbContext> options):base(options)
    {}
}
