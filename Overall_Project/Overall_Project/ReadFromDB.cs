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
    class ReadFromDB
    {
        //This method reads data from the database and adds the values to the public static Dictionary myFarm
        public static void readFromDB()
        {
            string ConnectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = 
                                   C:\Users\HP\Desktop\Shannon Juliette 19486116 Task 2\FarmInfomation.accdb;
                                   Persist Security Info = False";
            OleDbConnection conn = null;
            try
            {
                conn = new OleDbConnection(ConnectionStr);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM COWS", conn);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (Double.Parse(reader["Weight"].ToString()) != 0) //Error Handling for inconsistent data
                        {
                            //Creating a separate class for Jersey Cows
                            if (reader["Is jersy"].ToString().ToLower() == "true")
                            {
                                Variables.myFarm.Add(Int32.Parse(reader["ID"].ToString()), new Jersey_Cow(Int32.Parse(reader["ID"].ToString()), Double.Parse(reader["Amount of water"].ToString()), Double.Parse(reader["Daily cost"].ToString()), Double.Parse(reader["Weight"].ToString()), Int32.Parse(reader["Age"].ToString()), reader["Color"].ToString(), Double.Parse(reader["Amount of milk"].ToString())));
                            }
                            else
                            {
                                Variables.myFarm.Add(Int32.Parse(reader["ID"].ToString()), new Cow(Int32.Parse(reader["ID"].ToString()), Double.Parse(reader["Amount of water"].ToString()), Double.Parse(reader["Daily cost"].ToString()), Double.Parse(reader["Weight"].ToString()), Int32.Parse(reader["Age"].ToString()), reader["Color"].ToString(), Double.Parse(reader["Amount of milk"].ToString())));
                            }
                            //Incrementing the value of the public static variable totalMilkAmt by the amount of milk of Cows and Jersey_Cows
                            Variables.totalMilkAmt += Double.Parse(reader["Amount of milk"].ToString());
                        }
                    }       
                }

                cmd = new OleDbCommand("SELECT * FROM DOGS", conn);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (Double.Parse(reader["Weight"].ToString()) != 0) //Error Handling for inconsistent data
                        {
                            Variables.myFarm.Add(Int32.Parse(reader["ID"].ToString()), new Dog(Int32.Parse(reader["ID"].ToString()), Double.Parse(reader["Amount of water"].ToString()), Double.Parse(reader["Daily cost"].ToString()), Double.Parse(reader["Weight"].ToString()), Int32.Parse(reader["Age"].ToString()), reader["Color"].ToString()));
                        }        
                    }
                }

                cmd = new OleDbCommand("SELECT * FROM GOATS", conn);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (Double.Parse(reader["Weight"].ToString()) != 0) //Error Handling for inconsistent data
                        {
                            Variables.myFarm.Add(Int32.Parse(reader["ID"].ToString()), new Goat(Int32.Parse(reader["ID"].ToString()), Double.Parse(reader["Amount of water"].ToString()), Double.Parse(reader["Daily cost"].ToString()), Double.Parse(reader["Weight"].ToString()), Int32.Parse(reader["Age"].ToString()), reader["Color"].ToString(), Double.Parse(reader["Amount of milk"].ToString())));
                            Variables.totalMilkAmt += Double.Parse(reader["Amount of milk"].ToString());
                            //Incrementing the value of the public static variable totalMilkAmt by the amount of milk of Goats
                        }
                    }
                }

                cmd = new OleDbCommand("SELECT * FROM SHEEP", conn);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (Double.Parse(reader["Weight"].ToString()) != 0) //Error Handling for inconsistent data
                        {
                            Variables.myFarm.Add(Int32.Parse(reader["ID"].ToString()), new Sheep(Int32.Parse(reader["ID"].ToString()), Double.Parse(reader["Amount of water"].ToString()), Double.Parse(reader["Daily cost"].ToString()), Double.Parse(reader["Weight"].ToString()), Int32.Parse(reader["Age"].ToString()), reader["Color"].ToString(), Double.Parse(reader["Amount of wool"].ToString())));
                        }      
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//end of method

        //This method reads the prices from the database and assigns them to public static variables
        public static void setPrices()
        {
            List<double> farmPrices = new List<double>();
            string ConnectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = 
                                   C:\Users\HP\Desktop\Shannon Juliette 19486116 Task 2\FarmInfomation.accdb;
                                   Persist Security Info = False";
            OleDbConnection conn = null;
            try
            {
                conn = new OleDbConnection(ConnectionStr);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM COMMODITYPRICES", conn);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        farmPrices.Add(Double.Parse(reader["Price"].ToString()));
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach(double d in farmPrices)
            {
                if(d < 0)
                {
                    MessageBox.Show("Calculations may be inaccurate, negative prices exist");
                }
            }
            Variables.goatMilkPrice = farmPrices[0];
            Variables.sheepWoolPrice = farmPrices[1];
            Variables.waterPrice = farmPrices[2];
            Variables.govTax = farmPrices[3];
            Variables.jersyTax = farmPrices[4];
            Variables.cowMilkPrice = farmPrices[5];
        }//end of method

    }
}
