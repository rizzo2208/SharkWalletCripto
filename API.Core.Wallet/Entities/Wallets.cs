using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Core.Wallet.Entities
{
    public class Wallets
    {
        [Key]
        public int AccountID { get; set; }

        [ForeignKey("Balance")]
        public int BalanceID { get; set; }
        public Balance? balance { get; set; }

        [ForeignKey("Currency")]
        public string MoneyCurrencyID { get; set; }
        public MoneyCurrency? moneycurrency { get; set; }

       
    }
}
