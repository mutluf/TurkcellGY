using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IReadRepository<T>:IRepository<T>
    {
        public T GetAll();
    }
}
