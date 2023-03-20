using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.dalapi
{
    public interface ICrud<T>
    {
        void Create(T entity);
        //void Update(T entity);
        void Delete(string id);
        //List<T> Read();
        T ReadById(string id);
    }
}
