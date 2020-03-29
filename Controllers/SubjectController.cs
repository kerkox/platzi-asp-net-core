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
        return View(_context.Subjects.FirstOrDefault());
    }
    public IActionResult MultiSubject()
    {
      ViewBag.ThingDinamic = "The nun";
      ViewBag.date = DateTime.Now;
      return View("MultiSubject",_context.Subjects);
    }
    public SubjectController(SchoolContext context)
    {
      _context = context;
    }
  }
}