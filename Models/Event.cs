using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Topic { get; set; }
        [Display(Name = "Lecturer")]
        public int LecturerId { get; set; }
        [ForeignKey("LecturerId")]
        public virtual Lecturer Lecturers { get; set; }
        public Location Location { get; set; }
        [Display(Name = "Location")]
        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public virtual Location Locations { get; set; }
        public DateTime StartTime { get; set; }
    }
}
