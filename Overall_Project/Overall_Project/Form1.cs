using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Overall_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Both methods are called when Form1 is loaded so that the public static variables can be set accordingly
            //and the methods only have to be called once
            ReadFromDB.readFromDB();
            ReadFromDB.setPrices();
        }
        
        //This method searches for the ID of a livestock as input by the user in the public static Dictionary myFarm
        //it returns an appropriate message if not found
        private void search_btn_Click(object sender, EventArgs e)
        {
            int search_id = 0;
            if (string.IsNullOrEmpty(tb_id.Text))
            {
                MessageBox.Show("Please enter a value");
            }
            else
            {
                bool numericCheck = int.TryParse(tb_id.Text, out search_id);
                if (numericCheck)
                {
                    bool found = false;
                    string header = string.Format("{0,-6} {1,-10} {2,-9} {3,-6} {4,-6} {5,-6} {6,-5}", "ID |", "Water Amount |", "Daily Cost |", "Weight |", "Age |", "Colour |", "Type");
                    foreach (KeyValuePair<int, Animal> kvp in Variables.myFarm)
                    {
                        if (kvp.Key == search_id)
                        {
                            found = true;
                            tb_output.Text = header + "\r\n\r\n" + string.Format("{0,-10} {1,-13} {2,-10} {3,10} {4,10} {5,8} {6,7}", kvp.Key, kvp.Value.amtWater, kvp.Value.dailyCost, kvp.Value.weight, kvp.Value.age, kvp.Value.color, kvp.Value.type);
                            break; //if found no need to loop through the remaining elements in the Dictionary
                        }
                    }
                    if (found == false)
                    {
                        tb_output.Text += "No data found";
                    }
                }
                else
                {
                    MessageBox.Show("Data entered is not numeric. Try again");
                    tb_id.Clear();
                }
            }
        }//end of method

        //This method searches for all livestock with age above the one entered by the user
        //Prints appropriate message if no animals found aged above the threshold specified by user
        private void btn_age_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_age.Text))
            {
                MessageBox.Show("Please enter a value");
            }
            else
            {
                int age = 0;
                bool numericCheck = int.TryParse(tb_age.Text, out age);
                if (numericCheck)
                {
                    tb_output.Clear();
                    string header = "ID   |   Weight";
                    bool found = false;
                    int age_count = 0;
                    int total_count = 0;
                    tb_output.Text += header + "\r\n" + "--------------------------" + "\r\n";
                    if (age < 0)
                    {
                        MessageBox.Show("Result will display all animals since the age entered is negative");
                    }
                    if (age == 0)
                    {
                        MessageBox.Show("Result will display all animals since the age entered is zero");
                    }
                    foreach (KeyValuePair<int, Animal> kvp in Variables.myFarm)
                    {
                        total_count++;
                        if (kvp.Value.age > age)
                        {
                            found = true;
                            tb_output.Text += kvp.Key + "     " + kvp.Value.age + " " + "\r\n";
                            age_count++;
                        }
                    }
                    if (found == false)
                    {
                        tb_output.Text = "No animals found above that age";
                    }
                    else
                    {
                        tb_output.Text += "\r\nRatio of number of animals where the age is above entered threshold: " + age_count
                            + "\r\nCompared to total number of animals: " + total_count;
                    }
                }
                else
                {
                    MessageBox.Show("Data entered is not numeric. Try again");
                    tb_age.Clear();
                }
            } 
        }//end of method

        //This method clears all the textboxes
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_output.Clear();
            tb_age.Clear();
            tb_id.Clear();
        }//end of method

        //This method generates report depending on the radio button selected by the user
        //It retrieves values from the public static Dictionary myFarm and performs the appropriate calculations
        //The resultant report is displayed in textbox tb_output
        private void report_btn_Click(object sender, EventArgs e)
        {
            //This report shows the total profitability of the livestock
            if (report2.Checked)
            {
                tb_output.Text = Reports.report2();
            }
            //end of report

            //This report shows the total monthly tax paid to the government 
            if (report3.Checked)
            {
                tb_output.Text = Reports.report3();
            }//end of report

            //This report displays the total amount of milk produced by all cows and goats
            //It calls the public static variable totalMilkAmt whose value has been incremented when creating the public static Dictionary myFarm
            if (report4.Checked)
            {
                tb_output.Text = "Total amount of milk per day for Goats and Cows: \r\n" + Math.Round((Variables.totalMilkAmt/30),2);
            }//end of report

            //This report shows the average age of all livestock excluding dogs
            if (report5.Checked)
            {
                tb_output.Text = Reports.report5();
            }//end of report

            //This report shows the average profitability of Cows and Goats vs Sheep
            if (report6.Checked)
            {
                tb_output.Text = Reports.report6();
            }//end of report

            //This report shows the ratio for the cost of Dogs compared to total cost of livestock
            if (report7.Checked)
            {
                tb_output.Text = Reports.report7();
            }//end of report

            //This report shows the ratio of red coloured livestocked compared to the total number of livestock
            if (report9.Checked)
            {  
                tb_output.Text = Reports.report9();
            }//end of report

            //This report displays the total amount of tax paid for Jersey Cows
            if (report10.Checked)
            {
                tb_output.Text = Reports.report10();
            }//end of report

            //This report shows the total profitability of Jersey Cows
            if (report12.Checked)
            {
                tb_output.Text = Reports.report12();
            }//end of report

        }//end of method

        private void btn_sort_Click(object sender, EventArgs e)
        {
            Reports.writeSortedFile();
            tb_output.Text = "Textfile found at C:\\Users\\HP\\Desktop\\App Dev Assignment\\AscendingProfit.txt";
        }
    }
}
