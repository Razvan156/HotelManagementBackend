using BackendHotel.DAL.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BackendHotel.DAL.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IQueryable<T> Get(Expression<Func<T, bool>> predicate = null);
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null);
        void Commit();
        Task<T> Create(T entity, bool commit = true);
        T Update(T entity, bool commit = true);
        T Delete(T entity, bool commit = true);
    }
}
