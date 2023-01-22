using Microsoft.AspNetCore.Mvc;
using XtraCourses.Application.Abstractions;

namespace XtraCourses.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ILogger<CoursesController> _logger;
        private readonly ICourseService _courseService;

        public CoursesController(ILogger<CoursesController> logger, ICourseService courseService)
        {
            _logger = logger;
            _courseService = courseService;
        }

        [HttpGet("GetCourses")]
        public async Task<IActionResult> GetCourses()
            => Ok(await _courseService.GetCourses());

        [HttpGet("GetCourseDetails/{userId}")]
        public async Task<IActionResult> GetCourseDetails(Guid userId)
            => Ok(await _courseService.GetCourseDetails(userId));
    }
    
}