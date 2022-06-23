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
        
        public IActionResult Create()
        {
            return View(new VideoGame());   
        }
        [HttpPost]
        public IActionResult Create(VideoGame model)
        {
            List<VideoGame> videoGames = db.VideoGame.ToList();
            for(int i = 0; i < videoGames.Count; i++)
            {
                if (videoGames[i].Name == model.Name)
                {
                    ViewBag.Warning = "That Video Game already exists!";
                    return View(model);
                }
            }
            db.VideoGame.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }

        public IActionResult Details(int id)
        {
            return View(db.VideoGame.ToList().Where(vg => vg.Id == id).FirstOrDefault());
        }
    }
}
