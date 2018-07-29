using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CookingMethod
    {
        private string Food;
        private CookStrategy _cookStrategy;
        public void SetCookStrategy(CookStrategy cookStrategy)
        {
            this._cookStrategy = cookStrategy;
        }
        public void SetFood(string name)
        {
            Food = name;
        }
        public void Cook()
        {
            _cookStrategy.Cook(Food);
            Console.WriteLine();
        }
    }
}
