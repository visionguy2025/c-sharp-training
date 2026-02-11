using Microsoft.EntityFrameworkCore;
using Entities;

namespace EcommerceAPI;

public class EcomDbContext:DbContext
{
    public EcomDbContext(DbContextOptions<EcomDbContext> options):base(options)
    {}

    public DbSet<Category> Categories {get; set;}
    public DbSet<Product> Products {get; set;}
    public DbSet<Brand> Brands {get; set;}
}
