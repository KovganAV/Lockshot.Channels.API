using Microsoft.EntityFrameworkCore;
using Lockshot.Channels.API.Data;
using Lockshot.Channels.API.Models;
using Lockshot.Channels.API.Core.Interfaces;

namespace Lockshot.Channels.API.Core.Services
{
    public class ContentService : IContentService
    {
        private readonly AppDbContext _context;

        public ContentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Article>> GetArticlesAsync()
        {
            return await _context.Articles.ToListAsync();
        }

        public async Task<List<Video>> GetVideosAsync()
        {
            return await _context.Videos.ToListAsync();
        }
    }
}
