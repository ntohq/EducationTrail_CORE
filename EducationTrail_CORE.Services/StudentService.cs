using EducationTrail_CORE.Abstracts;
using EducationTrail_CORE.Interfaces;
using MongoDB.Driver;

namespace EducationTrail_CORE.Services
{
    /// <summary>
    /// Class <c>StudentService</c> models a services to manages <c><b>Student</b></c>s from The Education Trail's database.
    /// </summary>
    internal class StudentService : IStudent
    {
        public Student CreateStudent()
        {
            throw new NotImplementedException();
        }

        public Student CreateStudent(string name)
        {
            throw new NotImplementedException();
        }

        public Student CreateStudent(string name, string url, string attendingSchool)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public void SetStudentNames(string name)
        {
            throw new NotImplementedException();
        }

        public void SetStudentNames(string name, string nickName)
        {
            throw new NotImplementedException();
        }

        public void SetStudentNames(string first, string last, string middle)
        {
            throw new NotImplementedException();
        }

        public void SetStudentNames(string first, string last, string middle, string nickName)
        {
            throw new NotImplementedException();
        }
    }
}
