using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
  interface IRepository<T>
    {
        IEnumerable<T> GetList { get; }
        void Add(T entity);
        void Delete(T entity);
       
    }
}
