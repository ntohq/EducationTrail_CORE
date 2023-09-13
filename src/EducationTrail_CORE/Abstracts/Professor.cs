using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationTrail_CORE.Abstracts
{
    public class Professor
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Rating { get; set; }
        List<Course> Courses { get; set; } = new List<Course>();
    }
}
