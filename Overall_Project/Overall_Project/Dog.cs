using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overall_Project
{
    class Dog : Animal
    {
        //The class Dog inherits from base class Animal with no additional class fields
        public Dog(int id, double amtWater, double dailyCost, double weight, int age, string color) : base("Dog", id, amtWater, dailyCost, weight, age, color) { }

        //Overrides the inherited method from the abstract class Animal
        public override double CalcProfit()
        {
            double revenue = 0;
            return (revenue - CalcCost() + (Variables.govTax * weight)); //No goverment tax is paid for Dogs
        }
    }
}
