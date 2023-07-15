
namespace FPTUniversityPE.DataAccess.DAOs
{
    public class BaseDAO<T> : IBaseDAO<T> where T : class
    {
        protected readonly T _unitOfWork;
        public BaseDAO(T unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(T entity)
        {
            var result = _unitOfWork.GetType()
			.GetMethod("GetRepository")
			.MakeGenericMethod(typeof(T))
			.Invoke(_unitOfWork, null)
			.GetType()
			.GetMethod("Add").Invoke(_unitOfWork, new object[] { entity });
			return await Task.FromResult(true);
        }

        public Task<int> DeleteAsync(int id)
        {
           var result = _unitOfWork.GetType()
		   .GetMethod("GetRepository")
		   .MakeGenericMethod(typeof(T))
		   .Invoke(_unitOfWork, null)
		   .GetType()
		   .GetMethod("Delete").Invoke(_unitOfWork, new object[] { id });
		   return Task.FromResult(1);

        }

        public async Task<List<T>> GetAll()
        {
           var result = _unitOfWork.GetType()
		   .GetMethod("GetRepository")
		   .MakeGenericMethod(typeof(T))
		   .Invoke(_unitOfWork, null)
		   .GetType()
		   .GetMethod("AsQueryable").Invoke(_unitOfWork, null)
		   .GetType()
		   .GetMethod("ToListAsync").Invoke(_unitOfWork, null);
		   // cast result to List<T>
		   var users = await Task.FromResult(result);
		   return (List<T>)users;
		   
        }

        public Task<T> GetByIdAsync(int id)
        {
            var result = _unitOfWork.GetType()
			.GetMethod("GetRepository")
			.MakeGenericMethod(typeof(T))
			.Invoke(_unitOfWork, null)
			.GetType()
			.GetMethod("GetByIdAsync").Invoke(_unitOfWork, new object[] { id });
			return Task.FromResult((T)result);

        }

        public Task<int> UpdateAsync(T entity, int id)
        {
			var result = _unitOfWork.GetType()
			.GetMethod("GetRepository")
			.MakeGenericMethod(typeof(T))
			.Invoke(_unitOfWork, null)
			.GetType()
			.GetMethod("Update").Invoke(_unitOfWork, new object[] { entity });
			return Task.FromResult(1);
        }
    }
}
