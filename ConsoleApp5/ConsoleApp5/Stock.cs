using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
     abstract class Stock
    {
        private double _price;
        private string _model;
        private List<IUser> _users = new List<IUser>();
        public Stock(string symbol, string model, double price)
        {
            Symbol = symbol;
            _model = model;
            _price = price;
        }
        public void Attach(IUser user)
        {
            _users.Add(user);
        }

        public void Detach(IUser user)
        {    
            _users.Remove(user);
        }
        public void Notify()
        {
            foreach (IUser user in _users)
            {
                user.Update(this);
            }
        }
        public string Model
        {
            get { return _model; }
            set

            {
                if (_model != value)
                {
                    _model = value;
                    Notify();
                }
            }
        }
        public double Price
        {
            get { return _price; }
            set

            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }
        public string Symbol { get; }
    }
}