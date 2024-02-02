using Microsoft.EntityFrameworkCore;
using Person_Project.Entities;


namespace PersonProject.DbContexts
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {
        }
    }
}
