using SysacadApi.Core.Entities;

namespace SysacadApi.Application.DTOs
{
    public class CourseDTO
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
