using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overall_Project
{
    class Goat: Animal
    {
        //The class Goat inherits from base class Animal and has additional an class field amount of milk
        public double amtMilk;

        public Goat(int id, double amtWater, double dailyCost, double weight, int age, string color, double amtMilk) : base("Goat", id, amtWater, dailyCost, weight, age, color)
        {
            this.amtMilk = amtMilk;
        }

        //Overrides the inherited method from the abstract class Animal
        public override double CalcProfit()
        {
            double revenue = Variables.goatMilkPrice * amtMilk;

            return (revenue - CalcCost());
        }
    }
}
