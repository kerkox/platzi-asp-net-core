using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class StudentController : Controller
  {
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult MultiStudent()
    {
      var subject = new Subject();
      subject.Name = "Programming";
      ViewBag.ThingDinamic = "The nun";
      ViewBag.date = DateTime.Now;

      var subjectList = new List<Student>() {
        new Student {Name = "Jeniffer"},
        new Student {Name = "Pablo"},
        new Student {Name = "Santiago"},
        new Student {Name = "Paul"},
        new Student {Name = "Nathaly"}
      };

      return View("MultiStudent",subjectList);
    }
  }
}