using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overall_Project
{
    class Cow : Goat
    {
        //The Cow class inherits from the Goat class as they both have the class field amount of milk that other livestock do not have.
        public Cow(int id, double amtWater, double dailyCost, double weight, int age, string color, double amtMilk) : base(id, amtWater, dailyCost, weight, age, color, amtMilk)
        {
            type = "Cow";
        }

        //Overrides the inherited method from class Goat
        public override double CalcProfit()
        {
            double revenue = Variables.cowMilkPrice * amtMilk;
            return (revenue - CalcCost());
        }
    }
}
