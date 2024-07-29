using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base
{
    public class Repository<T> : IDisposable, IRepository<T> where T : Entity
    {
        public IList<T> All()
        {
            throw new NotImplementedException();
        }

        public T ById(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id, int userId)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
