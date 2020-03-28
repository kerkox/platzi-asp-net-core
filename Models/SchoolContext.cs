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

      modelBuilder.Entity<School>().HasData(school);

      modelBuilder.Entity<Subject>().HasData(
        new Subject { Name = "Matemáticas" },
        new Subject { Name = "Educación Física" },
        new Subject { Name = "Castellano" },
        new Subject { Name = "Ciencias Naturales" },
        new Subject { Name = "Programacion" }
      );


      modelBuilder.Entity<Student>().HasData(GenerateStudentRandom().ToArray());
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