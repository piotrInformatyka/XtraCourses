namespace XtraCourses.Application.Entities
{
    public class User
    {
        public string Person { get; set; }
        public string Email { get; set; }
        public string? Upn { get; set; }
        public string? Department { get; set; }
        public string? Location { get; set; }
        public string? ImportTag { get; set; }
        public string? Mobile { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
