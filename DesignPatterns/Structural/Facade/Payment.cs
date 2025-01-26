using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    internal class Payment
    {
        private readonly string _name;
        private readonly string _cardNumber;
        private readonly float _amount;

        public Payment(string name, string cardNumber, float amount)
        {
            _name = name;
            _cardNumber = cardNumber;
            _amount = amount;
        }

        public void Pay()
        {
            System.Console.WriteLine("Charging card with name " + _name);
        }
    }
}
