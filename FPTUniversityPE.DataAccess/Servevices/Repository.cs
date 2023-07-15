
using FPTUniversityPE.BusinessObject.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FPTUniversityPE.DataAccess.Servevices
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly FPTUniversityPEContext _db;
		protected DbSet<T> dbSet;

		public Repository(FPTUniversityPEContext db)
		{
			_db = db;
			dbSet = db.Set<T>();
		}
		public async Task Add(T entity) => await dbSet.AddAsync(entity);

		public async Task AddRange(List<T> list) => await dbSet.AddRangeAsync(list);

		public IQueryable<T> AsQueryable() => dbSet.AsNoTracking();

		public void Delete(T entity)
		{
			
			dbSet.Remove(entity);
			
		}
		public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool asNoTracking = true)
		=> asNoTracking ? dbSet.Where(expression).AsNoTracking() : dbSet.Where(expression);

		public async Task<T> GetByIdAsync(int id)
		=> await dbSet.FindAsync(id);

		public bool Update(T entity)
		{
			var entry = _db.Entry(entity);
			if (entry.State == EntityState.Detached)
			{
				dbSet.Attach(entity);
			}
			entry.State = EntityState.Modified;
			return true;
		}

		public bool UpdateRange(List<T> entities)
		{
			var entry = _db.Entry(entities);
			if (entry.State == EntityState.Detached)
			{
				dbSet.AttachRange(entities);
			}
			entry.State = EntityState.Modified;
			return true;
		}
	}
}
