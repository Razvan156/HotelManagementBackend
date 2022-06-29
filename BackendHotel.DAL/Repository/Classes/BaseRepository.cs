using BackendHotel.DAL.Entities;
using BackendHotel.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.DAL.Repository.Classes
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly HotelDBContext dbContext;
        protected readonly DbSet<T> table;

        public BaseRepository(HotelDBContext dbContext)
        {
            this.dbContext = dbContext;
            table = dbContext.Set<T>();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)
                return table.Where(predicate);

            return table;
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)
                return table
                    .Where(predicate);

            return table;
        }

        public int CountAll(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)
                return table
                    .Where(predicate)
                    .Count();

            return table.Count();
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public async Task<T> Create(T entity, bool commit = true)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<T> entry = await table.AddAsync(entity);
            entity = entry.Entity;
            if (commit)
                Commit();

            return entity;
        }

        public T Update(T entity, bool commit = true)
        {
            table.Update(entity);

            if (commit)
                Commit();

            return entity;
        }

        public T Delete(T entity, bool commit = true)
        {
            table.Remove(entity);

            if (commit)
                Commit();

            return entity;
        }
    }
}
