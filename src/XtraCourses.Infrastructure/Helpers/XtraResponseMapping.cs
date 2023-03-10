using System.Linq;
using XtraCourses.Application.Entities;
using XtraCourses.Application.ValueObject;
using XtraCourses.Infrastructure.Models;

namespace XtraCourses.Infrastructure.Helpers
{
    public static class XtraResponseMapping
    {
        public static (IEnumerable<User>, IEnumerable<Course>, IEnumerable<Project>) MapXtraResponse(IEnumerable<XtraResponseModel> inputProjects)
        {
            //inputProjects = inputProjects.GroupBy(x => x.ProjectId).Select(x => x.First()); duplicated

            var users = inputProjects.GroupBy(x => x.Person)
                .Select(y => y.First())
                .Select(u => new User()
                {
                    Person = u.Person,
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
                CourseId = x.CourseId,
                PersonId = x.Person,
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
