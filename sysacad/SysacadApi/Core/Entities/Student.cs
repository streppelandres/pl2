using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysacadApi.Core.Entities
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("EnrollmentId")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
