using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SysacadApi.Application.DTOs;
using SysacadApi.Core.Entities;
using SysacadApi.Core.Interfaces;

namespace SysacadApi.Presentation.Controllers
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
            var courses = courseRepository.GetAll();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(courses);
        }

        [HttpPost("{name}")]
        [ProducesResponseType(200, Type = typeof(CourseDTO))]
        public IActionResult CreateCourse(string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var course = courseRepository.Create(name);

            return Ok(mapper.Map<CourseDTO>(course));
        }
    }
}
