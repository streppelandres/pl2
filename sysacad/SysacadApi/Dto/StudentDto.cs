using SysacadApi.Models;

namespace SysacadApi.Dto
{
    public class StudentDto
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
