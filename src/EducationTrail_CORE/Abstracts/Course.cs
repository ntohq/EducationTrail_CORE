using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationTrail_CORE.Abstracts
{
    internal struct Course
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public University UniversityLocation { get; set; }
        public string Description { get; set; }
    }
}
