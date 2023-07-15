using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FPTUniversityPE.DataAccess.Servevices
{
	public interface IRepository<T> where T : class
	{
		IQueryable<T> AsQueryable();
		Task<T> GetByIdAsync(int id);
		Task Add(T entity);
		Task AddRange(List<T> list);
		bool Update(T entity);
		bool UpdateRange(List<T> entities);
		void Delete(T entity);
	}
}
