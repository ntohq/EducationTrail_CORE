using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationTrail_CORE.Abstracts
{
    public class Semester
    {
        public string Label { get; set; } = string.Empty;
        public List<Course> Courses { get; set; } = new List<Course>();
        public float GPA { get; set; }
        public float Performance { get; set; }
    }
}
