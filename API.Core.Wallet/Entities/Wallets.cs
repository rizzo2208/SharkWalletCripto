using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Wallet.Entities
{
    public class Wallets
    {
        [Key]
        public int AccountID { get; set; }

        [Required]
        public double? Balance { get; set; }

        [ForeignKey("Currency")]
        public int MoneyCurrencyID { get; set; }
        public MoneyCurrency? moneycurrency { get; set; }
    }
}
