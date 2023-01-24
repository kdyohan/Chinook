using Chinook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Chinook.Infrastructure
{
    public class ChinookContext : DbContext
    {
        public ChinookContext(DbContextOptions<ChinookContext> options) : base(options)       
        {
        }

        public DbSet<ChinookUser> ChinookUsers { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceLine> InvoiceLine { get; set; }
        public DbSet<MediaType> MediaType { get; set; }
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<Track> Track { get; set; }
        public DbSet<UserPlaylist> UserPlaylist { get; set; }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}