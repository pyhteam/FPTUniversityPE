
using FPTUniversityPE.BusinessObject.Entities;
using FPTUniversityPE.DataAccess.DAOs;
using FPTUniversityPE.DataAccess.Servevices;
using Microsoft.EntityFrameworkCore;

namespace FPTUniversityPE.DataAccess.UserDao
{
	public class UserDA : BaseDAO<IUnitOfWork>, IUserDA
	{
		public UserDA(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		public Task<bool> CreateAsync(User entity)
		{
			var result =  _unitOfWork.GetRepository<User>().Add(entity);
			return Task.FromResult(true);
		}

		public async Task<int> DeleteAsync(string id)
		{
			var user = await _unitOfWork.GetRepository<User>().GetByIdAsync(id);
			var result = await _unitOfWork.GetRepository<User>().Delete(user);
			return 1;

		}

		public async Task<User> GetAll()
		{
		throw new System.NotImplementedException();
		}

		public async Task<User> GetByIdAsync(string id)
		{
			throw new System.NotImplementedException();
		}

		public async Task<int> UpdateAsync(User entity, string id)
		{
			throw new System.NotImplementedException();
		}
	}
}
