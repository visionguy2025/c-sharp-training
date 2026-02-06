using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL;
using Entities;

public class ToDoAppDBContext:DbContext
{
    public ToDoAppDBContext(DbContextOptions<ToDoAppDBContext> options):base(options)
    {}

    public DbSet<User> Users {get; set;}
    public DbSet<Category> Categories {get; set;}
    public DbSet<Task> Tasks {get; set;}
}
