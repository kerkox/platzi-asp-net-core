using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class SchoolController : Controller
    {
        private SchoolContext _context;
        public IActionResult Index()
        {
            ViewBag.ThingDinamic = "The nun";
            var school = _context.Schools.FirstOrDefault();
            return View(school);
        }

        public SchoolController(SchoolContext context)
        {
            _context = context;
        }

    }
}