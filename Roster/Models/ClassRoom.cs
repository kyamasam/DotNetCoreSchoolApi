using System.Collections.Generic;

namespace Roster.Models
{
    public class ClassRoom
    {
        public int ClassRoomId { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; }
        public ICollection<Teacher> Teachers { get; set; }

        public virtual School Schools { get; set; }

    }
}