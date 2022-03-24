using Course.Data;
using Course.Models;
using Course.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Course.Controllers
{
    public class ReviewController : Controller
    {

        private readonly ApplicationDbContext _db;


        public ReviewController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Review> objlist = _db.Review;
            return View(objlist);
        }

        public IActionResult Create()
        {
           return View();
            
        }

    }
}
