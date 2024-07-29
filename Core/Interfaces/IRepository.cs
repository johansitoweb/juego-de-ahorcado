using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    internal interface IRepository<T> where T : IEntity
    {

        System.Collections.Generic.IList<T> All();
        T ById(int id);
        void Delete(int id, int userId);
        void Delete(T entity);
        void Dispose();
        void Insert(T entity);
        void Update(T entity);
    }
}
