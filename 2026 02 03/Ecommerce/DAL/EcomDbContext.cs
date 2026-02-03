using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using Entity;

namespace DAL;

public class EcomDbContext:DbContext
{
    public EcomDbContext(DbContextOptions<EcomDbContext> options):base(options)
    {}

    public DbSet<Product> Products {get; set;}
    public DbSet<Category> Categories {get; set;}
}
