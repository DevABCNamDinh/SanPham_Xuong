﻿using System.Linq.Expressions;

namespace Xuong_C_.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(Guid id);

        void insert(T entity);
        void update(T entity);
        void delete(T entity);
        void save();
        T FindBy(Expression<Func<T, bool>> predicate);

    }
}
