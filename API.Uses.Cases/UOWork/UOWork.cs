using API.Core.Wallet.DBContext;
using API.Data.Core.Repository.Clases;
using API.Data.Core.Repository.IRepository;

namespace API.Uses.Cases.UOWork
{
    public class UOWork : IUOWork
    {
        private readonly ApplicationDbContext _context;

        public IUserRepository UserRepo { get; private set; }

        public IMoneyCurrencyRepository MoneyCurrencyRepo { get; private set; }

        public IWalletRepository WalletRepo { get; private set; }

        public IBalanceRepository BalanceRepo{ get; private set; }




        public UOWork(ApplicationDbContext context)
        {
            _context = context;

            UserRepo = new UserRepository(context);
            MoneyCurrencyRepo = new MoneyCurrencyRepository(context);
            WalletRepo = new WalletRepository(context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
