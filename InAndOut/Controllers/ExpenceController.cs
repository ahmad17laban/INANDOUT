using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class ExpenceController : Controller
    {
        // using dependency 
        private readonly ApplicationDbContext _db;

        // now we can use the tables from the db (this a ctor function)
        public ExpenceController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            // here we retrive the items from the db
            IEnumerable<Expence> objList = _db.Expences;
            return View(objList);
            //return View();
        }
        // GET which shows the form of creating the item 
        public IActionResult Create()
        {
            // we create the items and

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expence obj)
        {
            // saving the item into the DB
            if (ModelState.IsValid)
            {
                _db.Expences.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }
        //GET Delete
        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var obj = _db.Expences.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        //POST for Delete 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost( int? id)
        {
            var obj = _db.Expences.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            
                _db.Expences.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

        }
        //GET 
        public IActionResult Update(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var obj = _db.Expences.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Expence obj)
        {
            // saving the item into the DB
            if (ModelState.IsValid)
            {
                _db.Expences.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }
}
