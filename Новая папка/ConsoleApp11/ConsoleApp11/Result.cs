using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Result
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public IEnumerable<Library> NameBook { get; set; }

        public Result(string Name,string Surname,IEnumerable<Library> Namebook)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.NameBook = Namebook;
        }
    }
}
