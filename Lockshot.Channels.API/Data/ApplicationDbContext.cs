using Lockshot.Channels.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Lockshot.Channels.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
