using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public Lecturer Lecturer { get; set; }
        public Location Location { get; set; }
        public DateTime StartTime { get; set; }
    }
}
