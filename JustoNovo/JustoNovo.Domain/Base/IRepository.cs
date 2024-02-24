using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JustoNovo.Domain.Base
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression); 
        Task<IEnumerable<T>> FindAllByCritery(Expression<Func<T, bool>> expression);
        Task<T> FindOneByCritery(Expression<Func<T, bool>> expression);
    }
}
