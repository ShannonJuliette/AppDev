using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overall_Project
{
    class Variables
    {
        //public static variables that will be used throughout the app
        //accounts for more effective use of memory space

        public static double goatMilkPrice;
        public static double sheepWoolPrice;
        public static double waterPrice;
        public static double govTax;
        public static double jersyTax;
        public static double cowMilkPrice;
        public static double totalMilkAmt;
        public static Dictionary<int, Animal> myFarm = new Dictionary<int,Animal>();
    }
}
