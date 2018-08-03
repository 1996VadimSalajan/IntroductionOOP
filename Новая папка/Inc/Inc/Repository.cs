using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inc
{
    class Repository<T>:IRepository<T>
    {
        List<T> list = new List<T>();
        public IEnumerable<T> GetList
        {
            get
            {
                return list;
            }
        }
        public void Add(T entity)
        {
            list.Add(entity);
        }
        public void Delete(T entity)
        {
            list.Remove(entity);
        }
    }
}
