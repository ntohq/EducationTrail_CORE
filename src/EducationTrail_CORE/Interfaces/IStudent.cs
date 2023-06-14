using EducationTrail_CORE.Abstracts;
using MongoDB.Bson.Serialization.Serializers;

namespace EducationTrail_CORE.Interfaces
{
    public interface IStudent
    {
        /// <summary>
        /// Method <c>CreateStudent</c>.
        /// </summary>
        /// <returns></returns>
        public Student CreateStudent();

        /// <summary>
        /// Method <c>CreateStudent</c>.
        /// </summary>
        /// <param name="name"><c></c>.</param>
        /// <returns></returns>
        public Student CreateStudent(string name);

        /// <summary>
        /// Method <c>CreateStudent</c>.
        /// </summary>
        /// <param name="name"><c></c>.</param>
        /// <param name="url"><c></c>.</param>
        /// <param name="attendingSchool"><c></c>.</param>
        /// <returns></returns>
        public Student CreateStudent(string name, string url, string attendingSchool);

        /// <summary>
        /// Method <c>GetAllStudent</c>.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetAllStudent();

        /// <summary>
        /// Method <c>GetStudents</c>.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetStudents();

        /// <summary>
        /// Method <c>SetStudentNames</c>.
        /// </summary>
        /// <param name="name"><c></c>.</param>
        public void SetStudentNames(string name);

        /// <summary>
        /// Method <cSetStudentNames></c>.
        /// </summary>
        /// <param name="name"><c></c>.</param>
        /// <param name="nickName"><c></c>.</param>
        public void SetStudentNames(string name, string nickName);

        /// <summary>
        /// Method <c>SetStudentNames</c>.
        /// </summary>
        /// <param name="first"><c></c>.</param>
        /// <param name="last"><c></c>.</param>
        /// <param name="middle"><c></c>.</param>
        public void SetStudentNames(string first, string last, string middle);

        /// <summary>
        /// Method <c>SetStudentNames</c>.
        /// </summary>
        /// <param name="first"><c></c>.</param>
        /// <param name="last"><c></c>.</param>
        /// <param name="middle"><c></c>.</param>
        /// <param name="nickName"><c></c>.</param>
        public void SetStudentNames(string first, string last, string middle, string nickName);
    }
}
