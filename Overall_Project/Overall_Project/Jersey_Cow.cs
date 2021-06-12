using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overall_Project
{
    class Jersey_Cow : Cow
    {
        public Jersey_Cow(int id, double amtWater, double dailyCost, double weight, int age, string color, double amtMilk) : base(id, amtWater, dailyCost, weight, age, color, amtMilk)
        {
            type = "Jersey_Cow";
        }

        //Overrides the inherited method from class Cow
        public override double CalcProfit()
        {
            double revenue = Variables.cowMilkPrice * amtMilk;
            double addTax = Variables.jersyTax * weight;
            return (revenue - CalcCost() - addTax);
        }
    }
}
