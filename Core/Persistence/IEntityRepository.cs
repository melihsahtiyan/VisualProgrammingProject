﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Domain.Concrete;

namespace Core.Persistence 
{ 
    public interface IEntityRepository<T> where T : Entity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}