using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template.InheritanceExample
{
    internal class Tea : Beverage
    {

        // Tea is brewed for 3 mins, so no need to override Beverage.Brew()

        protected override void AddCondiments()
        {
            if (CustomerWantsCondiments())
                System.Console.WriteLine("Adding lemon to tea");
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like lemon with your tea? (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }
}
