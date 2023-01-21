namespace XtraCourses.Application.ValueObject
{
    public class ProjectDetails
    {
        public string? CourseStartedDate { get; set; }
        public int? OpenedLessonsCount { get; set; }
        public string? CompletedDate { get; set; }
        public int? CompletedLessonsCount { get; set; }
        public int? TotalLessonsCount { get; set; }
        public string? HaveNotStarted { get; set; }
        public string? NotOnSchedule { get; set; }
        public string? HaveStarted { get; set; }
        public int? QuizScore { get; set; }
        public int? QuizScoreTotal { get; set; }
        public string? CertificateTitle { get; set; }
        public bool? IsPassed { get; set; }

    }
}
