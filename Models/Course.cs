using System;
using System.Collections.Generic;
using platzi_asp_net_core.Util;

namespace platzi_asp_net_core.Models
{
  public class Course : ObjectSchoolBase
  {
    public TimeType timeType {get; set;}
    public List<Subject> Subjects { get; set; }
    public List<Student> Students { get; set; }
    public string Address { get; set; }
    public string SchoolId {get; set; }
    public School School {get; set;}

    
  }
}