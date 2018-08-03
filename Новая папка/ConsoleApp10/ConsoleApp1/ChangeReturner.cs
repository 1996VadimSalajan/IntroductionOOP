using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  class ChangeReturner
    {
        ICoinRelease _coinRelease;
        IList<int> _denominations = new List<int> { 1, 2, 5, 10, 20, 50, 100, 200 };
        public ChangeReturner(ICoinRelease coinRelease)
        {
            _coinRelease = coinRelease;
        }
        public void GiveChange(int value)
        {
            int remainder = value;
            while (remainder > 0)
            {
                int coin = _denominations.Where(c => c <= remainder).Max();
                _coinRelease.Release(coin);
                remainder -= coin;
            }
        }
    }
}
