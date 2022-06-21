using Microsoft.AspNetCore.Mvc;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Controllers
{
    public class VideoGameController : Controller
    {
        public VideoGameContext db;
        public VideoGameController(VideoGameContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.VideoGame.ToList());
        }
    }
}
