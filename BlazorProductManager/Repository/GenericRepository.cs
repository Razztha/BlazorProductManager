
using BlazorProductManager.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace BlazorProductManager.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext DbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbContext dbContext)
        {
            DbContext = dbContext;
            _dbSet = DbContext.Set<T>();
        }
        public void Add(in T sender)
        {
            _dbSet.Add(sender);
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T GetLastItem()
        {
            return _dbSet.LastOrDefault();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public T GetByIdWithIncludes(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdWithIncludesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            var item = _dbSet.Find(id);
            _dbSet.Remove(item);
            return true;
        }

        public int Save()
        {
            return DbContext.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(in T sender)
        {
            _dbSet.Update(sender);
        }
    }
}
