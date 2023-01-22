namespace XtraCourses.Application.Entities
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
