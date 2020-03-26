using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class SubjectController : Controller
  {
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult MultiSubject()
    {
      var subject = new Subject();
      subject.Name = "Programming";
      ViewBag.ThingDinamic = "The nun";
      ViewBag.date = DateTime.Now;

      var subjectList = new List<Subject>() {
        new Subject {Name = "Matemáticas"},
        new Subject {Name = "Educación Física"},
        new Subject {Name = "Castellano"},
        new Subject {Name = "Ciencias Naturales"},
        new Subject {Name = "Programacion"}
      };

      return View("MultiSubject",subjectList);
    }
  }
}