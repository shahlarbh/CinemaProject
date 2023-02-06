namespace Core.Services.Contracts
{
    public interface ICrudService<T>
    {
        void Add(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        T Get(int id);
        List<T> GetAll();
    }
}
