using Microsoft.AspNetCore.Mvc;
using template_csharp_reviews_site.Models;
using System.Linq;

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

        public IActionResult Details(int id)
        {
            return View(db.VideoGame.ToList().Where(vg => vg.Id == id).FirstOrDefault());
        }
    }
}
