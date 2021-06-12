using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overall_Project
{
    class Sheep : Animal
    {
        //The class Sheep has its own unique class field which is amount of wool
        public double amtWool;

        public Sheep(int id, double amtWater, double dailyCost, double weight, int age, string color, double amtWool) : base("Sheep", id, amtWater, dailyCost, weight, age, color)
        {
            this.amtWool = amtWool;
        }

        //Overrides the inherited method from the abstract class Animal
        public override double CalcProfit()
        {
            double revenue = Variables.sheepWoolPrice * amtWool;
            return (revenue - CalcCost());
        }
    }
}
