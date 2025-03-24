using Microsoft.EntityFrameworkCore;
using Saber.Database.Providers.Interfaces;

namespace Saber.Database.Providers;

public class GenericProvider<T> : IProvider<T> where T : class
{
    public readonly Db DbCtx;

    public GenericProvider(Db db)
    {
        DbCtx = db;
    }

    public T Get(object id)
    {
        return DbCtx.Set<T>().Find(id);
    }

    public IQueryable<T> GetAll(bool trackChanges = false)
    {
        return trackChanges
            ? DbCtx.Set<T>()
            : DbCtx.Set<T>().AsNoTracking();
    }

    public T Add(T item)
    {
        DbCtx.Set<T>().Add(item);
        return item;
    }

    public T Update(T item)
    {
        return item;
    }

    public T Remove(T item)
    {
        DbCtx.Set<T>().Remove(item);
        return item;
    }

    public int Save()
    {
        return DbCtx.SaveChanges();
    }

    public T Get(int id)
    {
        return DbCtx.Set<T>().Find(id);
    }

    public T Get(string id)
    {
        return DbCtx.Set<T>().Find(id);
    }

    public T Get(Guid id)
    {
        return DbCtx.Set<T>().Find(id);
    }
}