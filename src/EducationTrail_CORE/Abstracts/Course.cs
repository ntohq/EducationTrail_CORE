namespace EducationTrail_CORE.Abstracts
{
    internal record Course
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public University UniversityLocation { get; set; }
        public string Description { get; set; }
    }
}
