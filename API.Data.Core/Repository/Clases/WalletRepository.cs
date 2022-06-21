using API.Core.Wallet.DBContext;
using API.Core.Wallet.Entities;
using API.Data.Core.Repository.IRepository;
using API.Generic.Core.Generics;

namespace API.Data.Core.Repository.Clases
{
    public class WalletRepository : GenericRepository<Wallets>, IWalletRepository
    {
        public WalletRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
