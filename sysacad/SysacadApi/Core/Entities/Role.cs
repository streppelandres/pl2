using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SysacadApi.Core.Entities
{
    public enum RoleName
    {
        Admin,
        Professor,
        Student
    }

    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }

        [Required]
        public RoleName RoleName { get; set; }
    }
}
