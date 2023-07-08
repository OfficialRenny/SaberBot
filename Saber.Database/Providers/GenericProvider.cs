using Microsoft.EntityFrameworkCore;
using Saber.Database.Providers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Database.Providers
{
    public class GenericProvider<T> : IProvider<T> where T : class
    {
        public readonly Db DbCtx;

        public GenericProvider(Db db)
        {
            DbCtx = db;
        }
        public T Get(object id)
            => DbCtx.Set<T>().Find(id);

        public T Get(int id)
            => DbCtx.Set<T>().Find(id);

        public T Get(string id)
            => DbCtx.Set<T>().Find(id);

        public T Get(Guid id)
            => DbCtx.Set<T>().Find(id);

        public IQueryable<T> GetAll(bool trackChanges = false)
            => trackChanges
                ? DbCtx.Set<T>()
                : DbCtx.Set<T>().AsNoTracking();

        public T Add(T item)
        {
            DbCtx.Set<T>().Add(item);
            return item;
        }

        public T Update(T item)
            => item;

        public T Remove(T item)
        {
            DbCtx.Set<T>().Remove(item);
            return item;
        }

        public int Save()
            => DbCtx.SaveChanges();
    }
}
