using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Lecturer
    {
        public string Name { get; set; }
        public List<Event> Events { get; set; }
    }
}
