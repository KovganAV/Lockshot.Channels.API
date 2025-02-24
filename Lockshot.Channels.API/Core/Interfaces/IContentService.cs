using Lockshot.Channels.API.Models;

namespace Lockshot.Channels.API.Core.Interfaces
{
    public interface IContentService
    {
        Task<List<Article>> GetArticlesAsync();
        Task<List<Video>> GetVideosAsync();
    }
}
