using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public interface ICrudBl<T>
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(string id, T entity);
        Task RemoveAsync(string id);
        Task<List<T>> GetAsync();
        Task<T?> GetAsyncById(string id);
    }
}
