using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SysacadApi.Dto;
using SysacadApi.Interfaces;
using SysacadApi.Models;

namespace SysacadApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private readonly ILogger<CourseController> logger;
        private readonly ICourseRepository courseRepository;
        private readonly IMapper mapper;

        public CourseController(ILogger<CourseController> logger, ICourseRepository courseRepository, IMapper mapper)
        {
            this.logger = logger;
            this.courseRepository = courseRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Course>))]
        public IActionResult GetCourses()
        {
            var courses = this.courseRepository.GetAll();

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(courses);
        }

        [HttpPost("{name}")]
        [ProducesResponseType(200, Type = typeof(CourseDto))]
        public IActionResult CreateCourse(string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var course = this.courseRepository.Create(name);

            return Ok(mapper.Map<CourseDto>(course));
        }
    }
}
