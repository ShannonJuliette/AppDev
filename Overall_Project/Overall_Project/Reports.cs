using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Overall_Project
{
    class Reports
    {
        //This report shows the total profitability of the livestock
        public static string report2()
        {
            double profit = 0;
            foreach (KeyValuePair<int, Animal> kvp in Variables.myFarm)
            {
                profit += kvp.Value.CalcProfit();
            }
            return "Total profitability per day: \r\n" + Math.Round((profit / 30),2);
        }//end of report

        //This report shows the total monthly tax paid to the government 
        public static string report3()
        {
            double daily_tax = 0;
            foreach (KeyValuePair<int, Animal> kvp in Variables.myFarm)
            {
                //dogs are not included
                if (kvp.Value.type != "Dog")
                {
                    daily_tax += (kvp.Value.weight * Variables.govTax);
                }
            }
            return "Total monthly tax paid to the government: \r\n" + Math.Round((daily_tax * 30), 2);
        }//end of report


        //This report displays the total amount of milk produced by all cows and goats
        //It calls the public static variable totalMilkAmt whose value has been incremented when creating the public static Dictionary myFarm
        public static string report4()
        {
            return "Total amount of milk per day for Goats and Cows: \r\n" + Math.Round((Variables.totalMilkAmt / 30),2);
        }//end of report

        //This report shows the average age of all livestock excluding dogs
        public static string report5()
        {
            int count = 0;
            double totalage = 0;
            foreach (KeyValuePair<int, Animal> kvp in Variables.myFarm)
            {
                if (kvp.Value.type != "Dog")
                {
                    totalage += kvp.Value.age;
                    count++;
                }
            }
            string output = "Average age of livestock (excl. Dogs):" + "\r\n\r\n" + Math.Round((totalage / count), 2);
            return output;
        }//end of report

        //This report shows the average profitability of Cows and Goats vs Sheep
        public static string report6()
        {
            int cow_goat_count = 0;
            int sheep_count = 0;
            double cow_goat_profit = 0;
            double sheep_profit = 0;
            foreach (KeyValuePair<int, Animal> kvp in Variables.myFarm)
            {
                if (kvp.Value.type == "Cow" || kvp.Value.type == "Goat" || kvp.Value.type == "Jersey_Cow")
                {
                    cow_goat_count++;
                    cow_goat_profit += kvp.Value.CalcProfit();
                }
                else if (kvp.Value.type == "Sheep")
                {
                    sheep_count++;
                    sheep_profit += kvp.Value.CalcProfit();
                }
            }
            return "Average profitability of Goats and Cows per month\r\n" + Math.Round((cow_goat_profit / cow_goat_count), 2) + "\r\n\r\n" +
                "Average profitability of Sheep per month \r\n" + Math.Round((sheep_profit / sheep_count), 2);
        }//end of report

        //This report shows the ratio for the cost of Dogs compared to total cost of livestock
        public static string report7()
        {
            double dog_cost = 0;
            double total_cost = 0;
            foreach (KeyValuePair<int, Animal> kvp in Variables.myFarm)
            {
                total_cost += kvp.Value.CalcCost();
                if (kvp.Value.type == "Dog")
                {
                    dog_cost += kvp.Value.CalcCost(); //No tax is paid to the government for dogs
                }
            }
            return "Ratio of Dogs' cost : Total cost: \r\n\r\n" + dog_cost + " : " + total_cost;
        }//end of report

        //This report shows the ratio of red coloured livestocked compared to the total number of livestock
        public static string report9()
        {
            int red_count = 0;
            int total_livestock = 0;
            foreach (KeyValuePair<int, Animal> kvp in Variables.myFarm)
            {
                total_livestock++;
                if (kvp.Value.color.ToLower() == "red")
                {
                    red_count++;
                }
            }
            return "Ratio of livestock with the colour red to total number of livestock\r\n\r\n" +
                    red_count + " out of " + total_livestock + " animals.";
        }//end of report

        //This report displays the total amount of tax paid for Jersey Cows
        //It includes Government tax and Jersey tax, both of them dependent on weight
        public static string report10()
        {
            double jersey_totaltax = 0;
            foreach (KeyValuePair<int, Animal> kvp in Variables.myFarm)
            {
                if (kvp.Value.type == "Jersey_Cow")
                {
                    jersey_totaltax += (Variables.govTax * kvp.Value.weight) + (Variables.jersyTax * kvp.Value.weight);
                }
            }
            return "Total tax paid for all Jersey Cows per day\r\n\r\n" + jersey_totaltax;
        }//end of report

        //This report shows the total profitability of Jersey Cows
        public static string report12()
        {
            double jersey_profit = 0;
            foreach (KeyValuePair<int, Animal> kvp in Variables.myFarm)
            {
                if (kvp.Value.type == "Jersey_Cow")
                {
                    jersey_profit += kvp.Value.CalcProfit();
                }
            }
            return "Total profitability of all Jersey Cows per month: \r\n" + Math.Round(jersey_profit,2);
        }//end of report

        //Quick Sort Iterative Algorithm
        public static int partition(List<int> arr, int low, int high)
        {
            int temp;
            int pivot = high; 

            //index of smaller element
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                //If current element is smaller than or equal to pivot
                if (Variables.myFarm[arr[j]].CalcProfit() <= Variables.myFarm[arr[pivot]].CalcProfit())
                {
                    i++;
                    //swap arr[i] and arr[j]
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            //swapping
            temp = arr[i + 1];
            arr[i + 1] = arr[high]; //or pivot
            arr[high] = temp;

            return i + 1;
        }
        public static void qSort(List<int> arr, int low,
                          int high)
        {
            int[] stack = new int[high - low + 1];

            //initialize top of stack
            int top = -1;

            //push initial values of low and high to stack
            stack[++top] = low;
            stack[++top] = high;

            //Keep popping from stack while is not empty
            while (top >= 0)
            {
                //Pop high and low
                high = stack[top--];
                low = stack[top--];

                //Set pivot element at its correct position in sorted array
                int p = partition(arr, low, high);

                //If there are elements on left side of pivot, then push left side to stack
                if (p - 1 > low)
                {
                    stack[++top] = low;
                    stack[++top] = p - 1;
                }

                //If there are elements on right side of pivot, then push right side to stack
                if (p + 1 < high)
                {
                    stack[++top] = p + 1;
                    stack[++top] = high;
                }
            }
        }//end of Quick Sort

        //This method sorts the profitability of livestock in ascending order and stores 
        //the ids and profit in a Dictionary
        public static Dictionary<int, double> profitSort()
        {
            List<int> ids = new List<int>();
            foreach (KeyValuePair<int, Animal> kvp in Variables.myFarm)
            {
                if (kvp.Value.type != "Dog")
                {
                    ids.Add(kvp.Key);
                }
            }
        
            qSort(ids, 0, ids.Count - 1);

            Dictionary<int,double> sorted_id = new Dictionary<int, double>();
            foreach (int id in ids)
            {
                sorted_id.Add(id, Variables.myFarm[id].CalcProfit());       
            }
            return sorted_id;
        }//end of method

        //This method writes to a textfile the id and profitability of the livestock in ascending order
        public static void writeSortedFile()
        {
            Dictionary<int, double> profit = profitSort();
            using (StreamWriter sw = new StreamWriter(@"C:\Users\HP\Desktop\App Dev Assignment\AscendingProfit.txt"))
            {
                sw.WriteLine("ID       |        Profit");
                sw.WriteLine("_________________________" + "\n");
                foreach (KeyValuePair<int, double> kvp in profit)
                {
                    sw.WriteLine(kvp.Key + "     |      " + kvp.Value);
                }
            }
        }//end of method
    }
}
