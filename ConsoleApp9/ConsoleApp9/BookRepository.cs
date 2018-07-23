using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class BookRepository : IRepository<Book>
    {
            
        List<Book> list = new List<Book>();
     
        public IEnumerable<Book> List
        {
            get
            {
                return list;
            }
        }
        public void Add(Book entity)
        {
            list.Add(entity);
        }
        public void Delete(Book entity)
        {
            list.Remove(entity);
        }
        public void Update(Book entity,Book newentity)
        {
            entity = list.FirstOrDefault(x => x == newentity);
      
        }
      
    }
}
