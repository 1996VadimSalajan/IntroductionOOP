using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Account
    {
        public delegate void AccountStateHandler(string message);
        public event AccountStateHandler Withdrawn;
        public event AccountStateHandler Adeed;
      
        private int _sum;

        public Account(int sum)
        {
            if (_sum > 0)
                _sum = sum;
        }
        public int CurrentSum
        {
            get { return _sum; }
        }
        public void Put(int sum)
        {
            _sum += sum;
            if (Adeed != null)
                Adeed($"Transfer {sum} Lei!");
        }
        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
                if (Withdrawn != null)
                    Withdrawn($"{sum} Lei get out!");
            }
            else
            {
                if (Withdrawn != null)
                    Withdrawn($"{sum} Lei not get on the card!");
            }
        }
    }
}
