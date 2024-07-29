using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IConverter<T, T2> : IDisposable
    {
        T2 Convert(T entity);
        List<T2> ConvertBulk(List<T> entities);
        T ConvertBack(T2 entity);
    }
}
