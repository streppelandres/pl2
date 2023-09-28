using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysacadApi.Core.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long DocumentNumber { get; set; }

        public string PhoneNumber { get; set; }

        public bool HasToChangePassword { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}
