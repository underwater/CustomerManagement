using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.Database.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected Repository(DbContext context)
        {
            Context = context;
            context.ChangeTracker.AutoDetectChangesEnabled = false;
            context.ChangeTracker.LazyLoadingEnabled = false;
            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public IQueryable<T> Queryable => Set.AsQueryable();

        private DbSet<T> Set => Context.Set<T>();

        private DbContext Context { get; }

        public void Add(T item)
        {
            Set.Add(item);
        }

        public async Task AddAsync(T item)
        {
            await Set.AddAsync(item).ConfigureAwait(false);
        }

        public void AddRange(IEnumerable<T> items)
        {
            Set.AddRange(items);
        }

        public async Task AddRangeAsync(IEnumerable<T> items)
        {
            await Set.AddRangeAsync(items).ConfigureAwait(false);
        }

        public bool Any()
        {
            return Set.Any();
        }

        public bool Any(Expression<Func<T, bool>> where)
        {
            return Set.Any(where);
        }

        public Task<bool> AnyAsync()
        {
            return Set.AnyAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> where)
        {
            return Set.AnyAsync(where);
        }

        public long Count()
        {
            return Set.LongCount();
        }

        public long Count(Expression<Func<T, bool>> where)
        {
            return Set.LongCount(where);
        }

        public Task<long> CountAsync()
        {
            return Set.LongCountAsync();
        }

        public Task<long> CountAsync(Expression<Func<T, bool>> where)
        {
            return Set.LongCountAsync(where);
        }

        public void Delete(object key)
        {
            Set.Remove(Select(key));
        }

        public async Task DeleteAsync(object key)
        {
            await Task.Run(() => Delete(key)).ConfigureAwait(false);
        }

        public async Task DeleteAsync(Expression<Func<T, bool>> where)
        {
            await Task.Run(() => Delete(where)).ConfigureAwait(false);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> where)
        {
            return Set.Where(where).FirstOrDefault();
        }

        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> where)
        {
            return Set.Where(where).FirstOrDefaultAsync();
        }

        public IEnumerable<T> List()
        {
            return Set.ToList();
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> where)
        {
            return Set.Where(where).ToList();
        }

        public async Task<IEnumerable<T>> ListAsync()
        {
            return await Set.ToListAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> where)
        {
            return await Set.Where(where).ToListAsync().ConfigureAwait(false);
        }

        public T Select(object key)
        {
            return Set.Find(key);
        }

        public Task<T> SelectAsync(object key)
        {
            return Set.FindAsync(key);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> where)
        {
            return Set.Where(where).SingleOrDefault();
        }

        public Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> where)
        {
            return Set.Where(where).SingleOrDefaultAsync();
        }

        public void Update(T item, object key)
        {
            Context.Entry(Select(key)).CurrentValues.SetValues(item);
        }

        public async Task UpdateAsync(T item, object key)
        {
            await Task.Run(() => Update(item, key)).ConfigureAwait(false);
        }
    }
}
