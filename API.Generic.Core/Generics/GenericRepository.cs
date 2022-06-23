using API.Core.Wallet.DBContext;

namespace API.Generic.Core.Generics
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _db;

        public GenericRepository(ApplicationDbContext db)
        {
            _db = db;
            
        }

        #region Delete

        public void Delete(int? id)
        {
            var entity = GetById(id);

            if (entity == null)
            {
                throw new Exception("No se encontro objeto");
            }
            else
            { 
                _db.Set<T>().Remove(entity);
            }
        }


        #endregion Delete

        #region GetById
        public IEnumerable<T> GetAll()
        {
            
            var val = _db.Set<T>().ToList();
            if (val == null)
            {
                return val;
            }
            return val;
        }

        public T GetById(int? id)
        {
            
            var aux = _db.Set<T>().Find(id);
            return aux;
        }
        #endregion GetById

        #region Insert
        public void Insert(T entity)
        {
            
            _db.Set<T>().Add(entity);
        }
        #endregion Insert

        #region Update
        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
        }
        #endregion Update
    }
}
