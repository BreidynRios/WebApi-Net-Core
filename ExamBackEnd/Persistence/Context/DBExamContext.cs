using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class DBExamContext : DbContext
    {
        public DBExamContext(DbContextOptions options) : base(options) 
        { }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
