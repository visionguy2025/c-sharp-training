using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EFCore
{
    public class NtierDbContext:DbContext
    {
        public NtierDbContext(DbContextOptions<NtierDbContext> options):base(options)
        {}

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
