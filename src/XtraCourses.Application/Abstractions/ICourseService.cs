using XtraCourses.Application.DTO;
using XtraCourses.Application.Entities;

namespace XtraCourses.Application.Abstractions
{
    public interface ICourseService
    {
        public Task<IEnumerable<CourseDto>> GetCourses();
        public Task<CourseDetails> GetCourseDetails(Guid courseId);
    }
}
