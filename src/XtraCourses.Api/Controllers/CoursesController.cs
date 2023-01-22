using Microsoft.AspNetCore.Mvc;
using XtraCourses.Application.Abstractions;

namespace XtraCourses.WebApi.Controllers
{
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ILogger<CoursesController> _logger;
        private readonly ICourseService _courseService;

        public CoursesController(ILogger<CoursesController> logger, ICourseService courseService)
        {
            _logger = logger;
            _courseService = courseService;
        }

        [HttpGet("courses")]
        public async Task<IActionResult> GetCourses()
            => Ok(await _courseService.GetCourses());

        [HttpGet("courses/{courseId}")]
        public async Task<IActionResult> GetCourseDetails(Guid courseId)
            => Ok(await _courseService.GetCourseDetails(courseId));
    }
    
}