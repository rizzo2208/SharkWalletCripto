using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Wallet.Entities
{
    public class MoneyCurrencys
    {
        [Key]
        public int MoneyCurrencyID { get; set; }

        [Required]
        public string moneyCurrency { get; set; }

        




    }
}
