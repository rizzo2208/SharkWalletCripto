using API.Core.Wallet.DBContext;
using API.Core.Wallet.Entities;
using API.Data.Core.Repository.IRepository;
using API.Generic.Core.Generics;

namespace API.Data.Core.Repository.Clases
{
    public class BalanceRepository : GenericRepository<Balances>, IBalanceRepository
    {
        public BalanceRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
