using API.Core.Wallet.Entities;
using API.Generic.Core.Generics;

namespace API.Data.Core.Repository.IRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetByEmail(string Email);
        bool ExisteUsuario(string Email);
    }
}
