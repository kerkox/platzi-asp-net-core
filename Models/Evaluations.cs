using System;

namespace platzi_asp_net_core.Models
{
  public class Evaluations
  {
    public string UniqueId { get; private set; }
    public string Name { get; set; }

    public Student Student { get; set; }
    public Subject Subject { get; set; }

    public float Note { get; set; }

    public Evaluations() => UniqueId = Guid.NewGuid().ToString();
  }
}