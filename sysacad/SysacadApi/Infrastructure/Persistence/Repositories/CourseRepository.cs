using SysacadApi.Core.Entities;
using SysacadApi.Core.Interfaces;

namespace SysacadApi.Infrastructure.Persistence.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SysacadContext context;

        public CourseRepository(SysacadContext context)
        {
            this.context = context;
        }

        public Course Create(string name)
        {
            var courseCreated = context.Add(new Course { Name = name });
            context.SaveChanges();
            return courseCreated.Entity;
        }

        public ICollection<Course> GetAll()
        {
            return context.Courses.OrderBy(course => course.CourseId).ToList();
        }
    }
}
