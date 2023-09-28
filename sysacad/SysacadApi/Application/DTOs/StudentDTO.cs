using SysacadApi.Core.Entities;

namespace SysacadApi.Application.DTOs
{
    public class StudentDTO
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
