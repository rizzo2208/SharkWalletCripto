using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Wallet.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? Email { get; set; }

        [ForeignKey ("Wallets")]
        public int AccountID { get; set; }
        public Wallets? account { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}
