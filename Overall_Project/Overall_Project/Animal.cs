using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overall_Project
{
    abstract class Animal
    {
        //Abstract class Animal is the base class for all the livestock
        //It contains the methods and class fields that all livestock share

        public string type;
        public int id;
        public double amtWater;
        public double dailyCost;
        public double weight;
        public int age;
        public string color;

        public Animal(string type, int id, double amtWater, double dailyCost, double weight, int age, string color)
        {
            this.type = type;
            this.id = id;
            this.amtWater = amtWater;
            this.dailyCost = dailyCost;
            this.weight = weight;
            this.age = age;
            this.color = color;
        }

        //Marked as abstract to force the subclasses to implement the method in their respective classes
        abstract public double CalcProfit();

        public double CalcCost()
        {
            return (dailyCost + (Variables.waterPrice * amtWater) + (Variables.govTax * weight));
        }

    }
}
