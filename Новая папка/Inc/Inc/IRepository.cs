using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inc
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetList { get; }
        void Add(T entity);
        void Delete(T entity);
    }
}
