using Microsoft.EntityFrameworkCore;

using Entities;

namespace DataAccessLayer;

public class TMdbContext:DbContext
{
    public TMdbContext(DbContextOptions<TMdbContext> options):base(options)
    {}

    public DbSet<ETask> Tasks {get; set;}
}
