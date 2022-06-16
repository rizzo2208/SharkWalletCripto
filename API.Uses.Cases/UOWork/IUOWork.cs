using API.Data.Core.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Uses.Cases.UOWork
{
    public interface IUOWork : IDisposable
    {
        IUserRepository UserRepo { get; }
        IWalletRepository WalletRepo { get; }
        IMoneyCurrencyRepository MoneyCurrencyRepo { get; }

        void Save();
    }
}
