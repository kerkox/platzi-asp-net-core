using System.Collections.Generic;

namespace platzi_asp_net_core.Models
{
    public class Student
    {
        public List<Evaluation> Evaluationes {get; set; } = new List<Evaluation>();
    }
}