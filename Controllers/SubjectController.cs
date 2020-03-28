using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class SubjectController : Controller
  {
    private SchoolContext _context;
    public IActionResult Index()
    {
        return View(new Subject { Name = "Programacion" });
    }
    public IActionResult MultiSubject()
    {
      var subject = new Subject();
      subject.Name = "Programming";
      ViewBag.ThingDinamic = "The nun";
      ViewBag.date = DateTime.Now;

     var subjectList = _context.Subjects.ToArray();

      return View("MultiSubject",subjectList);
    }
    public SubjectController(SchoolContext context)
    {
      _context = context;
    }
  }
}