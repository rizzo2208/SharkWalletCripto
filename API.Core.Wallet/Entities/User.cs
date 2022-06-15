using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Wallet.Entities
{
    internal class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [ForeignKey ("Wallet")]
        public int AccountID { get; set; }
        public Wallet? account { get; set; }

        //asdad
    }
}
