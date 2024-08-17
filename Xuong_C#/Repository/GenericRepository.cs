using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Xuong_C_.Context;

namespace Xuong_C_.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T FindBy(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.SingleOrDefault(predicate);
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void insert(T entity)
        {
             _dbSet.Add(entity);
        }

        public void save()
        {
           _context.SaveChanges();
        }

        public void update(T entity)
        {
           _context.Set<T>().Update(entity);
        }
    }
}
