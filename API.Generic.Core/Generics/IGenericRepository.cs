namespace API.Generic.Core.Generics
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int? id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int? id);
    }
}
