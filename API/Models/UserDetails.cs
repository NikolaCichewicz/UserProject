using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class UserDetails
    {
        [Key]
        public int userDetailId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string username { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string password { get; set; }

    }
}
