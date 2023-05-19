using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework;
public abstract class EfAsyncRepositoryBase<T, Context> : IAsyncRepository<T> where T : Entity, new() where Context : DbContext {
    private readonly Context _context;

    protected EfAsyncRepositoryBase(Context context) {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public async Task AddAsync(T entity) {
        await Table.AddAsync(entity);
    }  
    public async Task AddRangeAsync(List<T> entities) {
        await Table.AddRangeAsync(entities);
    }

    public void Delete(T entity) {
        Table.Remove(entity);
    }

    public async Task DeleteAsync(int id) {
        T entity = await GetByIdAsync(id) ?? throw new Exception("Entity not found");
        Table.Remove(entity);
    }


    public Task<T?> GetAsync(Expression<Func<T, bool>> expression) {
        return GetAsync(expression, true);
    }

    public Task<T?> GetAsync(Expression<Func<T, bool>> expression, bool tracking) {
        return IsTracking(tracking, Query(expression)).FirstOrDefaultAsync();
    }

    public Task<List<T>> GetAllAsync() {
        return IsTracking(true, Query()).ToListAsync();
    }

    public Task<List<T>> GetAllAsync(bool tracking) {
        return IsTracking(tracking, Query()).ToListAsync();
    }

    public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression, bool tracking = false) {
        return IsTracking(tracking, Query(expression)).ToListAsync();
    }

    public async Task<T?> GetByIdAsync(Int32 id) {
        return await Table.FindAsync(id);
    }

    public void Update(T entity) {
        Table.Update(entity);
    }

    public Task<Int32> SaveChangesAsync() {
        return _context.SaveChangesAsync();
    }

    private IQueryable<T> Query() => Table.AsQueryable();
    private IQueryable<T> Query(Expression<Func<T, bool>> expression) => Table.Where(expression);

    private IQueryable<T> IsTracking(bool tracking, IQueryable<T> query) {
        return tracking ? query : query.AsNoTracking();
    }
}