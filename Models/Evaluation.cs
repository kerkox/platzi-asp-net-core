namespace platzi_asp_net_core.Models
{
    public class Evaluation: ObjectSchoolBase
    {
    public string StudentId { get; set; }
    public Student Student { get; set; }
    public string SubjectId { get; set; }
    public Subject Subject { get; set; }

    public float Note { get; set; }

    public override string ToString()
    {
      return $"{Note}, {Student.Name}, {Subject.Name}";
    }
    }
}