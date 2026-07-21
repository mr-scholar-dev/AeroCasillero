using AeroCasilleroProyecto.Interfaces;

namespace AeroCasilleroProyecto.DAL;

public abstract class InMemoryRepository<T> : IRepository<T> where T : class
{
    protected readonly List<T> Items = new();

    public virtual IEnumerable<T> GetAll() => Items;

    public abstract T? GetById(int id);

    public abstract int Add(T entity);

    public abstract bool Update(T entity);

    public abstract bool Delete(int id);
}
