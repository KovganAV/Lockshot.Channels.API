using Lockshot.Channels.API.Models;
using Lockshot.Channels.API.Data;
using System.Threading.Tasks;

namespace Lockshot.Channels.API.Services
{
    public class MessageService
    {
        private readonly ApplicationDbContext _context;

        public MessageService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveMessage(Massage message)
        {
            _context.Add(message);
            await _context.SaveChangesAsync();
        }
    }
}
