using EducationTrail_CORE.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationTrail_CORE
{
    internal interface ICourse
    {
        IEnumerable<Course> GetAll();
    }

    class InMemoryCourses : ICourse
    {
        List<Course> courses;

        InMemoryCourses()
        {
            courses = new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    Name = "Object Oriented Programming",
                    Description = "A fun class with Dr. Bob Howel.",
                    UniversityLocation = new University() { Name = "Pensacola Christian College" }
                },
                new Course()
                {
                    Id = 2,
                    Name = "Database I",
                    Description = "A fun class with Dr. Sparks.",
                    UniversityLocation = new University() { Name = "Pensacola Christian College" }
                },
                new Course()
                {
                    Id = 3,
                    Name = "Networks II",
                    Description = "A fun class with Mr. Stemen.",
                    UniversityLocation = new University() { Name = "Pensacola Christian College" }
                },
                new Course()
                {
                    Id = 4,
                    Name = "EN126",
                    Description = "A fun class with Mrs. Poulin.",
                    UniversityLocation = new University() { Name = "Pensacola Christian College" }
                },
                new Course()
                {
                    Id = 5,
                    Name = "Calculus I",
                    Description = "A fun class with Mr. Kove.",
                    UniversityLocation = new University() { Name = "Pensacola Christian College" }
                },
            };
        }

        public IEnumerable<Course> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
