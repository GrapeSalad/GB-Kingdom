using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GBKingdom.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GBKingdom.Controllers
{
    public class GummiController : Controller
    {
        // GET: /<controller>/
        private GBKingdomContext db = new GBKingdomContext();
        public IActionResult Index()
        {
            return View(db.Gummies.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Gummi gummi)
        {
            db.Gummies.Add(gummi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Gummi thisGummi = db.Gummies.FirstOrDefault(Gummies => Gummies.id == id);
            return View(thisGummi);
        }

        [HttpPost]
        public IActionResult Edit(Gummi gummi)
        {
            db.Entry(gummi).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Gummi thisGummi = db.Gummies.FirstOrDefault(Gummies => Gummies.id == id);
            return View(thisGummi);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Gummi thisGummi = db.Gummies.FirstOrDefault(Gummies => Gummies.id == id);
            db.Gummies.Remove(thisGummi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Gummi thisGummi = db.Gummies.FirstOrDefault(Gummies => Gummies.id == id);
            return View(thisGummi);
        }
    }
}
