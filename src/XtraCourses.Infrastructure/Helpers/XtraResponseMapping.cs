using System.Linq;
using XtraCourses.Application.Models;
using XtraCourses.Application.ValueObject;
using XtraCourses.Infrastructure.Models;

namespace XtraCourses.Infrastructure.Helpers
{
    public static class XtraResponseMapping
    {
        public static (IEnumerable<User>, IEnumerable<Course>, IEnumerable<Project>) MapExtraResponse(IEnumerable<XtraResponseModel> inputProjects)
        {
            var users = inputProjects.GroupBy(x => x.Person)
                .Select(y => y.First())
                .Select(u => new User()
                {
                    Department = u.Department,
                    Email = u.Email,
                    ImportTag = u.ImportTag,
                    Location = u.Location,
                    Mobile = u.Mobile,
                    Upn = u.Upn
                });
            var courses = inputProjects.GroupBy(x => x.CourseId)
                .Select(y => y.First())
                .Select(c => new Course()
                {
                    CourseName = c.Course,
                    CourseId = c.CourseId
                });

            var projects = inputProjects.Select(x => new Project()
            {
                ProjectId = x.ProjectId,
                ProjectName = x.Project,
                ProjectDetails = new ProjectDetails()
                {
                    CertificateTitle = x.CertificateTitle,
                    CompletedDate = x.CompletedDate,
                    CompletedLessonsCount = x.CompletedLessonsCount,
                    CourseStartedDate = x.CourseStartedDate,
                    HaveNotStarted = x.HaveNotStarted,
                    HaveStarted = x.HaveStarted,
                    IsPassed = x.IsPassed,
                    NotOnSchedule = x.NotOnSchedule,
                    OpenedLessonsCount = x.OpenedLessonsCount,
                    QuizScore = x.QuizScore
                }
            });
            
            return (users, courses, projects);
        }
    }
}
