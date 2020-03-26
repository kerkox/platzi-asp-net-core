using System;
using System.Collections.Generic;

namespace platzi_asp_net_core.Models
{
  public class School : ObjectSchoolBase
  {
    public int CreateYear { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public SchoolTypes SchoolType { get; set; }
    public List<Course> Courses { get; set; }

    public School()
    {
        
    }
    public School(string name, int year) => (Name, CreateYear) = (name, year);

    public School(string name, int year, SchoolTypes schoolType, string country = "", string city = "") : base()
    {
      (Name, CreateYear) = (name, year);
      Country = country;
      City = city;
    }

    public override string ToString()
    {
      return $"Name: \"{Name}\", School Type: {SchoolType} {System.Environment.NewLine} Country: {Country}, City: {City}";
    }

  }
}