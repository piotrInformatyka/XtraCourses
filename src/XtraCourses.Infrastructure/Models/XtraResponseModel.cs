namespace XtraCourses.Infrastructure.Models
{
    public class XtraResponseModel
    {
        public string Project { get; set; }
        public Guid ProjectId { get; set; }
        public string Course { get; set; }
        public Guid CourseId { get; set; }
        public string Person { get; set; }
        public string Email { get; set; }
        public string Upn { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string ImportTag { get; set; }
        public string CourseStartedDate { get; set; }
        public int OpenedLessonsCount { get; set; }
        public string CompletedDate { get; set; }
        public int CompletedLessonsCount { get; set; }
        public int TotalLessonsCount { get; set; }
        public string HaveNotStarted { get; set; }
        public string NotOnSchedule { get; set; }
        public string HaveStarted { get; set; }
        public int QuizScore { get; set; }
        public int QuizScoreTotal { get; set; }
        public string CertificateTitle { get; set; }
        public string Mobile { get; set; }
        public bool IsPassed { get; set; }
        public string CertificateBlobUri { get; set; }
    }
}
