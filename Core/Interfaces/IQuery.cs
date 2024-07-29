using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IQuery<T, T2> : IDisposable
    {
        T2 DoQuery(T parameters);
    }
}
