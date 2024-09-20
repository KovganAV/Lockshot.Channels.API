using Lockshot.Channels.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Lockshot.Channels.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Massage> Massages { get; set; }
    }
}
