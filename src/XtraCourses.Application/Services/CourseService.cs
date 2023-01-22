using Microsoft.EntityFrameworkCore;
using XtraCourses.Application.Abstractions;
using XtraCourses.Application.DTO;

namespace XtraCourses.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly IDataContext _dataContext;

        public CourseService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<CourseDto>> GetCourses()
            => await _dataContext.Courses
                .AsNoTracking()
                .Include(x => x.Projects)
                .OrderByDescending(x =>
                    x.Projects.Where(x => x.ProjectDetails.IsPassed != null && x.ProjectDetails.IsPassed.Value)
                        .Select(x => x.PersonId)
                        .Distinct()
                        .Count())
                .Select(x => x.AsDto())
                .ToListAsync();


        public async Task<CourseDetails> GetCourseDetails(Guid courseId)
        {
            var projects = await _dataContext.Projects
                .AsNoTracking()
                .Include(x => x.Course)
                .Where(x => x.CourseId == courseId)
                .ToListAsync();

            return new CourseDetails()
            {
                CourseId = projects.First().CourseId,
                CourseName = projects.First().Course.CourseName,
                OpenedLessons = projects.Sum(x => x.ProjectDetails.OpenedLessonsCount ?? 0),
                CompletedLessons = projects.Sum(x => x.ProjectDetails.CompletedLessonsCount ?? 0),
                UsersPassedCourse =
                    projects.Where(x => x.ProjectDetails.IsPassed != null && x.ProjectDetails.IsPassed.Value)
                        .Select(x => x.PersonId)
                        .Distinct()
                        .Count(),
                UsersCount = projects.Select(x => x.PersonId).Distinct().Count()
            };
        }
    }
}
