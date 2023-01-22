using XtraCourses.Application.ValueObject;

namespace XtraCourses.Application.Entities
{
    public class Project
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public Guid CourseId { get; set; }
        public string PersonId { get; set; }
        public string ProjectName { get; set; }
        public ProjectDetails ProjectDetails { get; set; }
        public virtual User User { get; set; }
        public virtual Course Course { get; set; }
    }
}
