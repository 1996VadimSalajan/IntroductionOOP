using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inc
{
    class Controller
    {
        private readonly IBook _book;
        private readonly IPerson _person;
      

        public Controller(IBook book,IPerson person)
        {
            _book = book;
            _person = person;
        }
        public static void Add()
        {
          
        }
    }
}
