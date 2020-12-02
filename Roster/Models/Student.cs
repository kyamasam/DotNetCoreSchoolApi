using System.Collections.Generic;

namespace Roster.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassRoomId { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }

    }
}