using System;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            var school = new School();
            school.FoundationYear = 2005;
            school.SchoolId = Guid.NewGuid().ToString();
            school.Name = "Platzi School";
            return View(school);
        }
    }
}