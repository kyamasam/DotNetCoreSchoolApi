using Microsoft.AspNetCore.Mvc;
using Roster.Models;

namespace Roster.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return new Student
            {
                Id = id,
                Name = "Example Student",
                Class = new Class
                {
                    Id = 1,
                    Name = "Example School",
                    Teacher = new Teacher
                    {
                        Id = 1,
                        Name = "Example Teacher",
                        School = new School
                        {
                            Id = 1,
                            City = "Arusha",
                            Name = "Example School",
                            State = "Arusha State",
                        }
                    },
                },
            };
        }
    }
}