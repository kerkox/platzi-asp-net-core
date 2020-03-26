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
            school.CreateYear = 2005;
            school.Name = "Platzi School";
            school.SchoolType = SchoolTypes.HighSchool;
            school.City = "CALI";
            school.Country = "COLOMBIA";
            school.Address = "Av siempre viva";

            ViewBag.ThingDinamic = "The nun";

            return View(school);
        }
    }
}