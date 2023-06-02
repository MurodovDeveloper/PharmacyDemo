using System.Linq.Expressions;

namespace Application.Interfaces;

public interface IRepository<T> where T : class
{
    Task<List<T>> GetAll(Expression<Func<T, bool>> expression);
    Task<T> Get(Guid Id);
    Task<T> AddAsync(T entity);
    //Task<T> CreateAsync(T entity);
    Task<ICollection<T>> AddRangeAsync(ICollection<T> entities);
    Task<bool> UpdateAsync(T entity);
    Task<bool> DeleteAsync(T entity);
}
