using System;

namespace platzi_asp_net_core.Models
{
    public abstract class ObjectSchoolBase
    {
        public string Id {get; private set;}
        public string Name { get; set; }

        public ObjectSchoolBase()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Name},{Id}";
        }
    }
}