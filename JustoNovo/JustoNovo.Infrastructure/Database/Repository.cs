using JustoNovo.Domain.Base;
using JustoNovo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JustoNovo.Infrastructure.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected DbSet<T> Query { get; set; }
        protected DbContext Context { get; set; }

        public Repository(JustoDbContext context)
        {
            this.Context = context;
            this.Query = Context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await Query.AddAsync(entity);
            await Context.SaveChangesAsync();  
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return Query.AnyAsync(expression);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await Query.FindAsync(id);
            Query.Remove(entity);
            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAllByCritery(Expression<Func<T, bool>> expression)
        {
            return await this.Query.Where(expression).ToListAsync();
        }

        public async Task<T> FindOneByCritery(Expression<Func<T, bool>> expression)
        {
            return await this.Query.FirstOrDefaultAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           return await Query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Query.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            Query.Update(entity);
            await Context.SaveChangesAsync();
        }
    }
}
