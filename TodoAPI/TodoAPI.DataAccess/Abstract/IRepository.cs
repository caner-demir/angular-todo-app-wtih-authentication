﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TodoAPI.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        T Get(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null, string properties = null);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
