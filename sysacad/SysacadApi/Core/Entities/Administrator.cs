using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysacadApi.Core.Entities
{
    public class Administrator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdministratorId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
