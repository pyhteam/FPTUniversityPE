
namespace FPTUniversityPE.DataAccess.DAOs
{
	public class BaseDAO<T>
	{
		protected readonly T _unitOfWork;
		public BaseDAO(T unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

	}
}
