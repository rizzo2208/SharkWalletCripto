using API.Data.Core.Repository.IRepository;

namespace API.Uses.Cases.UOWork
{
    public interface IUOWork : IDisposable
    {
        IUserRepository UserRepo { get; }
        IWalletRepository WalletRepo { get; }
        IMoneyCurrencyRepository MoneyCurrencyRepo { get; }
        IBalanceRepository BalanceRepo { get; }

        void Save();
    }
}
