using System;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            var subject = new Subject();
            subject.Name = "Programming";
            ViewBag.ThingDinamic = "The nun";
            ViewBag.date = DateTime.Now;

            return View(subject);
        }
    }
}