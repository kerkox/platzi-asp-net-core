using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class StudentController : Controller
  {
    private SchoolContext _context;
    public IActionResult Index()
    {
        return View(new Student { Name = "Jeniffer" });
    }
    public IActionResult MultiStudent()
    {
      var subject = new Subject();
      subject.Name = "Programming";
      ViewBag.ThingDinamic = "The nun";
      ViewBag.date = DateTime.Now;
      var studentsList = _context.Students.ToArray();
      return View("MultiStudent", studentsList);
    }

    public StudentController(SchoolContext context)
    {
        _context = context;
    }
  }
}