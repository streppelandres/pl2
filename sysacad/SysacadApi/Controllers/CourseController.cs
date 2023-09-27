using Microsoft.AspNetCore.Mvc;
using SysacadApi.Interfaces;
using SysacadApi.Models;

namespace SysacadApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : Controller
    {
        private readonly ILogger<CourseController> logger;
        private readonly ICourseRepository courseRepository;

        public CourseController(ILogger<CourseController> logger, ICourseRepository courseRepository)
        {
            this.logger = logger;
            this.courseRepository = courseRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Course>))]
        public IActionResult Get()
        {
            var courses = this.courseRepository.GetAll();

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(courses);
        }
    }
}
