using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inc
{
    class Controller
    {
        IRepository<Book> _book;
        IRepository<Person> _person;
        public Controller(IRepository<Book> bookRepository,IRepository<Person> person)
        {
            _book = bookRepository;
            _person = person;
        }   
    }
}
