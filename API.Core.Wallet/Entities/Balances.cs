using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Wallet.Entities
{
    public class Balances
    {
        [Key]
        public int BalanceID { get; set; }

        [Required]
        public string? balance { get; set; }
    }
}
