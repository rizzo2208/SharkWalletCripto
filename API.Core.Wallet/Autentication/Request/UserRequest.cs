using System.ComponentModel.DataAnnotations;

namespace API.Core.Wallet.Autentication.Request
{
    public class UserRequest
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
