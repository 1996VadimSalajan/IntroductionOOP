using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class User:IUser
    {
        private readonly string _name;

        public User(string name)
        {
            _name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0}, Company {1} has new model car {2} at price {3:C}", _name, stock.Symbol,stock.Model, stock.Price);
        }
        public Stock Stock {get; set; }

    }
}
