using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lockshot.Channels.API.Models;

namespace Lockshot.Channels.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class ContentController : ControllerBase
    {
        private static readonly List<Article> Articles = new()
        {
            new Article { Id = 1, Title = "React Best Practices", Description = "Learn about best practices in React development." },
            new Article { Id = 2, Title = "Understanding Redux", Description = "A deep dive into state management with Redux." },
            new Article { Id = 3, Title = "ASP.NET Core Tips", Description = "Tips and tricks for building robust APIs." }
        };

        private static readonly List<Video> Videos = new()
        {
            new Video { Id = 1, Title = "React Tutorial", VideoId = "dQw4w9WgXcQ", VideoUrl = "https://www.youtube.com/watch?v=XvrBYyY2IAQ&t=1196s"},
            new Video { Id = 2, Title = "Introduction to .NET", VideoId = "9bZkp7q19f0", VideoUrl = "https://www.youtube.com/watch?v=XvrBYyY2IAQ&t=1196s"}
         };

        [HttpGet("articles")]
        [Authorize]
        public async Task<IActionResult> GetArticles()
        {
            return Ok(Articles);
        }

        [HttpGet("videos")]
        [Authorize]
        public async Task<IActionResult> GetVideos()
        {
            return Ok(Videos);
        }
    }
}