using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysacadApi.Core.Entities
{
    public class Professor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfessorId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("CourseId")]
        public virtual ICollection<Course> Courses { get; set; }

    }
}
