using Microsoft.AspNetCore.Mvc;
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
    }
}
