using Lockshot.Channels.API.Models;
using Lockshot.Channels.API.Data;
using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> DeleteMessage(int messageId)
        {
            var message = await _context.Massages.FindAsync(messageId);
            if (message == null) return false;

            _context.Massages.Remove(message);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Massage> EditMessage(int messageId, string newText)
        {
            var message = await _context.Massages.FindAsync(messageId);
            if (message == null) return null;

            message.Text = newText;
            await _context.SaveChangesAsync();
            return message;
        }
    }
}
