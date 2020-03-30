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

    [Route("Subject/Index/{subjectId}")]
    public IActionResult Index(string subjectId)
    {
      if (!string.IsNullOrWhiteSpace(subjectId))
      {

        var subject = from subj in _context.Subjects
                      where subj.Id == subjectId
                      select subj;
        return View(subject.SingleOrDefault());
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