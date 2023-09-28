using SysacadApi.Models;

namespace SysacadApi.Dto
{
    public class CourseDto
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
