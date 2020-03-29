using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace platzi_asp_net_core.Models
{
  public class SchoolContext : DbContext
  {
    public DbSet<School> Schools { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Evaluation> Evaluations { get; set; }

    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      var school = new School();
      school.CreateYear = 2005;
      school.Name = "Platzi School";
      school.SchoolType = SchoolTypes.HighSchool;
      school.City = "CALI";
      school.Country = "COLOMBIA";
      school.Address = "Av siempre viva";

      //Load course from school
      var courses = LoadCourses(school);

      //for each course load subjects
      var subjects = loadSubjects(courses);

      //for each course load students
      var students = LoadStudents(courses);

      modelBuilder.Entity<School>().HasData(school);
      modelBuilder.Entity<Course>().HasData(courses.ToArray());
      modelBuilder.Entity<Subject>().HasData(subjects.ToArray());
      modelBuilder.Entity<Student>().HasData(students.ToArray());
    }

    private List<Student> LoadStudents(List<Course> courses)
    {
      var listaStudents = new List<Student>();

      Random rnd = new Random();
      foreach (var course in courses)
      {
        int cantRandom = rnd.Next(5, 20);
        var tmplist = GenerateStudentRandom(course, cantRandom);
        listaStudents.AddRange(tmplist);
      }
      return listaStudents;
    }

    private static List<Subject> loadSubjects(List<Course> courses)
    {
      var listFull = new List<Subject>();
      foreach (var course in courses)
      {
        var tmpList = new List<Subject> {
          new Subject{ CourseId = course.Id,Name="Matemáticas"} ,
          new Subject{ CourseId = course.Id, Name="Educación Física"},
          new Subject{ CourseId = course.Id, Name="Castellano"},
          new Subject{ CourseId = course.Id, Name="Ciencias Naturales"},
          new Subject{ CourseId = course.Id, Name="Programación"}
        };
        listFull.AddRange(tmpList);
      }

      return listFull;
    }

    private static List<Course> LoadCourses(School school)
    {
      var listCourses = new List<Course>(){
        new Course(){
          SchoolId = school.Id,
          Name = "101",
          timeType = TimeType.Morning
        },
        new Course{SchoolId = school.Id, Name = "201", timeType = TimeType.Morning},
        new Course{SchoolId = school.Id, Name = "301", timeType = TimeType.Morning},
        new Course{SchoolId = school.Id, Name = "401", timeType = TimeType.Afternoon},
        new Course{SchoolId = school.Id, Name = "501", timeType = TimeType.Afternoon},
      };
      return listCourses;
    }

    private List<Student> GenerateStudentRandom(Course course, int quantity)
    {
      string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
      string[] lastname1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
      string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

      var listaStudents = from n1 in name1
                          from n2 in name2
                          from a1 in lastname1
                          select new Student { Name = $"{n1} {n2} {a1}" };

      return listaStudents.OrderBy((al) => al.Id).Take(quantity).ToList();
    }

    private List<Student> GenerateStudentRandom()
    {
      string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
      string[] lastname1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
      string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

      var listStudents = from n1 in name1
                         from n2 in name2
                         from a1 in lastname1
                         select new Student
                         {
                           Name = $"{n1} {n2} {a1}"
                         };

      return listStudents.OrderBy((al) => al.Id).ToList();
    }

  }

}