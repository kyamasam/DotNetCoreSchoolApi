using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Roster.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; }
        public ICollection<ClassRoom> ClassRooms { get; set; }
        
        public virtual School School { get; set; }

    }
}