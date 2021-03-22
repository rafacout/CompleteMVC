using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        Task Add(T entity);

        Task<T> GetById(Guid id);

        Task<List<T>> GetAll();

        Task Update(T entity);

        Task Remove(Guid id);

        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);

        Task<int> SaveChanges();
    }
}
