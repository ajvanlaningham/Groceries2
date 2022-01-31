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
           
            if(ModelState.IsValid)
            {
                _db.Recipies.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(obj);

        }

        //get
        public IActionResult Edit(int? id)
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }
            var RecipeFromDb = _db.Recipies.Find(id);
            //var RecipeFromDbFirst = _db.Recipies.FirstOrDefault(i => i.Id == Id);
            //var RecipeFromDbSingle = _db.Recipies.SingleOrDefault(i => i.Id == Id);

            if (RecipeFromDb == null)
            {
                return NotFound();
            }
                
                
            return View(RecipeFromDb);
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Recipe obj)
        {

            if (ModelState.IsValid)
            {
                _db.Recipies.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);

        }

        //get
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var RecipeFromDb = _db.Recipies.Find(id);
            //var RecipeFromDbFirst = _db.Recipies.FirstOrDefault(i => i.Id == Id);
            //var RecipeFromDbSingle = _db.Recipies.SingleOrDefault(i => i.Id == Id);

            if (RecipeFromDb == null)
            {
                return NotFound();
            }


            return View(RecipeFromDb);
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Recipies.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
       
       
                _db.Recipies.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
     
        }

        public IActionResult LookSee(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var RecipeFromDb = _db.Recipies.Find(id);
            //var RecipeFromDbFirst = _db.Recipies.FirstOrDefault(i => i.Id == Id);
            //var RecipeFromDbSingle = _db.Recipies.SingleOrDefault(i => i.Id == Id);

            if (RecipeFromDb == null)
            {
                return NotFound();
            }


            return View(RecipeFromDb);
        }
    }
}
