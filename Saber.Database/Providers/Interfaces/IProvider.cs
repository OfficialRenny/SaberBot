﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Database.Providers.Interfaces
{
    public interface IProvider<T> where T : class
    {
        T Get(object id);

        IQueryable<T> GetAll(bool trackChanges = false);

        T Add(T item);
        T Update(T item);
        T Remove(T item);

        int Save();
    }
}
