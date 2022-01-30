using Groceries2.Data;
using Groceries2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groceries2.Controllers
{
    public class RecipeController : Controller
    {

        private readonly ApplicationDbContext _db;

        public RecipeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Recipe> objRecipeList = _db.Recipies.ToList();
            return View(objRecipeList);
        }

        //get
        public IActionResult Create()
        {

            return View();
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Recipe obj)
        {
            _db.Recipies.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
