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
      return View("MultiStudent", _context.Students);
    }

    [Route("Student/{studentId}")]
    public IActionResult Index(string studentId)
    {
      if (!string.IsNullOrWhiteSpace(studentId))
      {

        var studentFound = from student in _context.Students
                      where student.Id == studentId
                      select student;
        return View(studentFound.SingleOrDefault());
      }
      else
      {
        return View("MultiStudent", _context.Students);
      }
    }

    public IActionResult MultiStudent()
    {
      ViewBag.ThingDinamic = "The nun";
      ViewBag.date = DateTime.Now;
      return View("MultiStudent", _context.Students);
    }

    public StudentController(SchoolContext context)
    {
        _context = context;
    }
  }
}