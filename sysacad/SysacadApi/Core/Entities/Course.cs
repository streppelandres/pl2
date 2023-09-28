using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysacadApi.Core.Entities
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public short MaxStudents { get; set; }

        [ForeignKey("EnrollmentId")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        [ForeignKey("ProfessorId")]
        public virtual Professor Professor { get; set; }

    }
}
