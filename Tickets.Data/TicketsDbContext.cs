using Microsoft.EntityFrameworkCore;
using Tickets.Core.Entities;

namespace Tickets.Data
{
    public class TicketsDbContext : DbContext
    {
        public TicketsDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Segments> Segments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
