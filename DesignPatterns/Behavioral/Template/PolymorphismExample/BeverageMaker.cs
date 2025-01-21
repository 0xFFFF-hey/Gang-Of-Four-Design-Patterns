using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template.PolymorphismExample
{
    internal class BeverageMaker
    {
        private Beverage _beverage;

        public BeverageMaker(Beverage beverage)
        {
            _beverage = beverage;
        }

        public void SetBeverage(Beverage beverage)
        {
            _beverage = beverage;
        }

        public void MakeBeverage()
        {
            // Common operations
            BoilWater();
            PourIntoCup();

            // Unique operations
            _beverage.Prepare();
        }

        private void BoilWater()
        {
            System.Console.WriteLine("Boiling water");
        }

        private void PourIntoCup()
        {
            System.Console.WriteLine("Pouring boiled water into cup");
        }
    }
}
