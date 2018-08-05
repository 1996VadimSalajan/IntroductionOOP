using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inc
{
    class Book : IBook
    {

        public string NameBook { get; set; }
        public int AgeBook { get; set; }
        public object Name { get; internal set; }
        public int GetNumberBook(int number)
        {
            return number;
        }
    }
}
