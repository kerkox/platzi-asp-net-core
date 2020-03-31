using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class CourseController : Controller
  {
    private SchoolContext _context;
    public IActionResult Index()
    {
      return View("MultiCourse", _context.Courses);
    }

    [Route("Course/{courseId}")]
    public IActionResult Index(string courseId)
    {
      if (!string.IsNullOrWhiteSpace(courseId))
      {

        var courseFound = from course in _context.Courses
                      where course.Id == courseId
                      select course;
        return View(courseFound.SingleOrDefault());
      }
      else
      {
        return View("MultiCourse", _context.Courses);
      }
    }
    public IActionResult MultiCourse()
    {
      ViewBag.ThingDinamic = "The nun";
      ViewBag.date = DateTime.Now;
      return View("MultiCourse", _context.Courses);
    }

    public CourseController(SchoolContext context)
    {
        _context = context;
    }
  }
}