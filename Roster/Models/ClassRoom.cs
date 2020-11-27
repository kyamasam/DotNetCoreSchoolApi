using System.Collections.Generic;

namespace Roster.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}