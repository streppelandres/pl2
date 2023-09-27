using SysacadApi.Data;
using SysacadApi.Interfaces;
using SysacadApi.Models;

namespace SysacadApi.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SysacadContext context;
        
        public CourseRepository(SysacadContext context)
        {
            this.context = context;
        }

        public ICollection<Course> GetAll()
        {
            return context.Courses.OrderBy(course => course.CourseId).ToList();
        }
    }
}
