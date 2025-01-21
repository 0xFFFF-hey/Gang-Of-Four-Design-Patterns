using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template.InheritanceExample
{
    internal class Coffee : Beverage
    {
        protected override void Brew()
        {
            System.Console.WriteLine("Brewing coffee for 5 mins");
        }

        protected override void AddCondiments()
        {
            if (CustomerWantsCondiments())
                System.Console.WriteLine("Adding cream to coffee");
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like cream with your coffee? (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }
}
