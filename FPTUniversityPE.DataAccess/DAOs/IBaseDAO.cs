using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPTUniversityPE.DataAccess.DAOs
{
	internal interface IBaseDAO<T1,T2>
	{
		Task<T2> GetAll();
		Task<T2> GetByIdAsync(string id);
		Task<bool> CreateAsync(T1 entity);
		Task<int> UpdateAsync(T1 entity, string id);
		Task<int> DeleteAsync(string id);
	}
}
