namespace EducationTrail_CORE.Abstracts
{
    public record University
    {
        public string Name { get; set; } = string.Empty;
        public string Acronym { get; set; } = string.Empty;
        List<Course> Courses { get; set; } = new List<Course>();
    }
}