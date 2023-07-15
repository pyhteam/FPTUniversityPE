using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPTUniversityPE.DataAccess.DAOs
{
	internal interface IBaseDAO<T1>
	{
		Task<List<T1>> GetAll();
		Task<T1> GetByIdAsync(int id);
		Task<bool> CreateAsync(T1 entity);
		Task<int> UpdateAsync(T1 entity, int id);
		Task<int> DeleteAsync(int id);
	}
}
