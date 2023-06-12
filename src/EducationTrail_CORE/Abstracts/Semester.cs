namespace EducationTrail_CORE.Abstracts
{
    public record Semester
    {
        public ObjectId AttendingUniversity { get; set; }
        List<Course> Courses { get; set; } = new List<Course>();
        public string Term { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
    }
}
