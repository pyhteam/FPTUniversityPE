
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

		public async Task<int> DeleteAsync(int id)
		{
			var user = await _unitOfWork.GetRepository<User>().GetByIdAsync(id);
		    _unitOfWork.GetRepository<User>().Delete(user);
			return 1;

		}

		public async Task<List<User>> GetAll()
		{
		    var users = await _unitOfWork.GetRepository<User>().AsQueryable().ToListAsync();
			return users;
		}

		public async Task<User> GetByIdAsync(int id)
		{
			var user = await _unitOfWork.GetRepository<User>().GetByIdAsync(id);
			return user;
		}

		public async Task<int> UpdateAsync(User entity, int id)
		{
			var user = await _unitOfWork.GetRepository<User>().GetByIdAsync(id);
			if (user != null)
			{
				user.name = entity.name;
				user.RoleId = entity.RoleId;
				

				_unitOfWork.GetRepository<User>().Update(user);
				return 1;
			}
			return 0;
		}
	}
}
