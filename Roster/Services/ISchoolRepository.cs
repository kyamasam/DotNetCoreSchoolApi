using System.Collections.Generic;
using Roster.Models;

namespace Roster.Services
{
    public interface ISchoolRepository
    {
        // the repository gives us access to data
        public List<School> GetSchools();
        //getSingle
        public School GetSchoolById(int id);
        //create
        public School CreateSchool(School school);
        //edit
        public School EditSchool(int id, School school);
    }
}