using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.dalapi
{
    public interface ICrud<T>
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(string id, T entity);
        Task RemoveAsync(string id);
        Task<List<T>> ReadAsync();
        Task<T> ReadByIdAsync(string id);


   
    }
}
