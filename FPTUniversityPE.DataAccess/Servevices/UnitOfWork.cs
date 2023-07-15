using FPTUniversityPE.BusinessObject.Data;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPTUniversityPE.DataAccess.Servevices
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly FPTUniversityPEContext dbContext;
		private readonly IServiceProvider _serviceProvider;
		private IDbContextTransaction _transaction;
		public UnitOfWork(FPTUniversityPEContext db, IServiceProvider serviceProvider)
		{
			dbContext = db;
			this._serviceProvider = serviceProvider;
		}

		public void BeginTransaction()
		{
			_transaction = dbContext.Database.BeginTransaction();
		}

		public void CommitTransaction()
		{
			if (_transaction != null)
			{
				_transaction.Commit();
				_transaction.Dispose();
			}
		}
		private bool disposedValue = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					dbContext.Dispose();
				}
				disposedValue = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
		}

		public IRepository<T> GetRepository<T>() where T : class
		{
			return _serviceProvider.GetService<IRepository<T>>();
		}

		public void RollbackTransaction()
		{
			if (_transaction != null)
			{
				_transaction.Rollback();
				_transaction.Dispose();
			}
		}

		public int SaveChanges()
		{
			return dbContext.SaveChanges();
		}

		public async Task<int> SaveChangesAsync()
		{
			return await dbContext.SaveChangesAsync();
		}
	}
}
