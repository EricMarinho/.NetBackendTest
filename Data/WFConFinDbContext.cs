using Microsoft.EntityFrameworkCore;
using WFConFin.Models;

namespace WFConFin.Data
{
    public class WFConFinDbContext : DbContext
    {
        public WFConFinDbContext(DbContextOptions<WFConFinDbContext> options) : base(options)
        {
        }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Person> People { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<State>().ToTable("State");
            modelBuilder.Entity<City>().ToTable("City");
            modelBuilder.Entity<Person>().ToTable("Person");
        }
    }
}
