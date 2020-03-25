using System;
using System.Collections.Generic;
using platzi_asp_net_core.Util;

namespace platzi_asp_net_core.Models
{
  public class Course : ObjectSchoolBase, IPlace
  {
    public TimeType timeType {get; set;}
    public List<Subject> Subjects { get; set; }
    public List<Student> Students { get; set; }
    public string Address { get; set; }

    public void CleanPlace()
    {
      Printer.DrawLine();
      Console.WriteLine("Cleaning establishment");
      Console.WriteLine($"Course: {Name} clean");
    }
  }
}