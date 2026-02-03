using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccessLayer;

public class EFDbContext:DbContext
{
    public EFDbContext(DbContextOptions<EFDbContext> options):base(options)
    {}

    DbSet<Product> Products {get; set;}
    DbSet<User> Users {get; set;}
}
