using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Controllers
{
    public class ReviewController : Controller
    {
        public VideoGameContext db;

        public ReviewController(VideoGameContext db)
        {
            this.db = db;
        }

        public IActionResult Create()
        {
            ViewBag.VideoGameId = new SelectList(db.VideoGames.ToList(), "Id", "Name");
            return View(new Review());
        }

        [HttpPost]

        public IActionResult Create(Review model)
        {
            model.PublishDate = DateTime.Now;
            db.Reviews.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(db.Reviews.ToList());
        }

        public IActionResult Update(int id)
        {
            Review review = db.Reviews.Find(id);
            if(review == null)
            {
                return View("Error");
            }
            return View(review);
        }

        [HttpPost]

        public IActionResult Update(Review model)
        {
            db.Reviews.Update(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(db.Reviews.ToList().Where(r => r.Id == id).FirstOrDefault());
        }
    }
}
