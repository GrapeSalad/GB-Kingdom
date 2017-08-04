using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GBKingdom.Models;

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
    }
}
