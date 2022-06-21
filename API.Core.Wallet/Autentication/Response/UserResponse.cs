using System.ComponentModel.DataAnnotations;

namespace API.Core.Wallet.Autentication.Response
{
    public class UserResponse
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string? Email { get; set; } 
        [Required]
        public string? password { get; set; }
    }
}
