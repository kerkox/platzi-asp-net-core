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
        return View(_context.Students.FirstOrDefault());
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