namespace EducationTrail_CORE.Abstracts
{
    /// <summary>
    /// Record <c>Student</c> models.
    /// </summary>
    public abstract record Student
    {
        public ObjectId Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string ImgUrl { get; set; } = string.Empty;
        public string Attends { get; set; } = string.Empty;
        List<Semester> Semesters { get; set; } = new List<Semester>();
    }
}