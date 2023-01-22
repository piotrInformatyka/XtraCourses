namespace XtraCourses.Application.DTO
{
    public class CourseDetails
    {
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
        public int OpenedLessons { get; set; }
        public int CompletedLessons { get; set; }
        public int UsersPassedCourse { get; set; }
        public int UsersCount { get; set; }
    }
}
