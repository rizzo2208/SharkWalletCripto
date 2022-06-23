using API.Core.Wallet.DBContext;
using API.Core.Wallet.Entities;
using API.Data.Core.Repository.IRepository;
using API.Generic.Core.Generics;

namespace API.Data.Core.Repository.Clases
{
    public class MoneyCurrencyRepository : GenericRepository<MoneyCurrencys>,IMoneyCurrencyRepository
    {
        public MoneyCurrencyRepository(ApplicationDbContext db) : base(db)
        {
        }

       
    }
}
