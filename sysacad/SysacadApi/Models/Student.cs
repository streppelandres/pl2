using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysacadApi.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        [ForeignKey("CourseId")]
        public virtual ICollection<Course> Courses { get; set; }

    }
}
