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
      return View("MultiSubject", _context.Subjects);
    }

    [Route("Subject/{subjectId}")]
    public IActionResult Index(string subjectId)
    {
      if (!string.IsNullOrWhiteSpace(subjectId))
      {

        var subjectFound = from subject in _context.Subjects
                      where subject.Id == subjectId
                      select subject;
        return View(subjectFound.SingleOrDefault());
      }
      else
      {
        return View("MultiSubject", _context.Subjects);
      }
    }
    public IActionResult MultiSubject()
    {
      ViewBag.ThingDinamic = "The nun";
      ViewBag.date = DateTime.Now;
      return View("MultiSubject", _context.Subjects);
    }
    public SubjectController(SchoolContext context)
    {
      _context = context;
    }
  }
}