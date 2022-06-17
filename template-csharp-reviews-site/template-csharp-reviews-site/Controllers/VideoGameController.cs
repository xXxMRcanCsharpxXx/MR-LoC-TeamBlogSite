using Microsoft.AspNetCore.Mvc;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Controllers
{
    public class VideoGameController : Controller
    {
        private List<VideoGame> db = new List<VideoGame>() { new VideoGame() { Id = 1, Name = "PacMan" }, new VideoGame() { Id = 2, Name = "SWKOTOR" },  new VideoGame() { Id = 3, Name = "SWTOR" }, };
        public IActionResult Index()
        {
            return View(db);
        }
    }
}
