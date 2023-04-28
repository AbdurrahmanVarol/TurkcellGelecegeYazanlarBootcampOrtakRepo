using System.Linq.Expressions;
using VotingApp.Entities;

namespace VotingApp.DataAccess.Interfaces;
public interface IAsyncRepository<T> where T : Entity, new() {
    public Task<List<T>> GetAllAsync();
    public Task<List<T>> GetAllAsync(bool tracking);
    public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression, bool tracking);

    public Task<T?> GetAsync(Expression<Func<T, bool>> expression);
    public Task<T?> GetAsync(Expression<Func<T, bool>> expression, bool tracking);

    public Task<T?> GetByIdAsync(int id);

    public Task AddAsync(T entity);
    public void Update(T entity);
    public void Delete(T entity);
    public Task DeleteAsync(int id);

    public Task<int> SaveChangesAsync();
}