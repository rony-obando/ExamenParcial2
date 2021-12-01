using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfeces
{
    public interface IServices<T>
    {
        void Add(T t);
        List<T> FindAll();
    }
}
