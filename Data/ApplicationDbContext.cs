using Microsoft.EntityFrameworkCore;
using TaskApp.Web.Models.Entities;

namespace TaskApp.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        // Here we Create the three Tables
        public DbSet<Person> People { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Models.Entities.Task> Tasks { get; set; }
    }
}
