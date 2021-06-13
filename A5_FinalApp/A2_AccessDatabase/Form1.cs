using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace A2_AccessDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            adHash(); //Method to read contents of the database and add to hash table
        }

        private void adHash()
        {
            OleDbConnection conn = null;
            String ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\\Users\\athen\\Documents\\IT Y2 S2\\Application Development\\A5_FinalApp\\Farm.accdb'";
            //String ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\\Users\\athen\\Desktop\\FarmInfo.accdb'";
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            
            String[] tableNames = new string[] { "Cows", "Goats", "Sheep", "Dogs", "Prices"};
            for (int i = 0; i < tableNames.Length; i++)
            {

                OleDbCommand cmd = new OleDbCommand("Select * from " + tableNames[i].ToString(), conn);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    //If the database is empty display this error message
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("There are no rows", "Error!");
                    }
                    while (reader.Read())
                    {
                        string str = "";
                        for (int j = 0; j <= reader.FieldCount - 1; j++)
                        {
                            str = str + reader[j].ToString() + ",";
                        }
                        string[] lines = str.Split(',');

                        switch (tableNames[i].ToLower())
                        {
                            case "cows":
                                if (lines[7].ToLower() == "true")
                                {
                                    Dictionary.animalDictionary.Add(Convert.ToInt32(lines[0]), new JerseyCow(Int32.Parse(lines[0]), Double.Parse(lines[1]), Double.Parse(lines[2]), Double.Parse(lines[3]), Int32.Parse(lines[4]), lines[5], Double.Parse(lines[6]), bool.Parse(lines[7])));
                                    break;
                                }
                                else
                                {
                                    Dictionary.animalDictionary.Add(Int32.Parse(lines[0]), new Cows(Int32.Parse(lines[0]), Double.Parse(lines[1]), Double.Parse(lines[2]), Double.Parse(lines[3]), Int32.Parse(lines[4]), lines[5], Double.Parse(lines[6]), bool.Parse(lines[7])));
                                    break;
                                }
                            case "goats":
                                Dictionary.animalDictionary.Add(Int32.Parse(lines[0]), new Goat(Int32.Parse(lines[0]), Double.Parse(lines[1]), Double.Parse(lines[2]), Double.Parse(lines[3]), Int32.Parse(lines[4]), lines[5], Double.Parse(lines[6])));
                                break;

                            case "sheep":
                                Dictionary.animalDictionary.Add(Int32.Parse(lines[0]), new Sheep(Int32.Parse(lines[0]), Double.Parse(lines[1]), Double.Parse(lines[2]), Double.Parse(lines[3]), Int32.Parse(lines[4]), lines[5], Double.Parse(lines[6])));
                                break;

                            case "dogs":
                                Dictionary.animalDictionary.Add(Int32.Parse(lines[0]), new Dogs(Int32.Parse(lines[0]), Double.Parse(lines[1]), Double.Parse(lines[2]), Int32.Parse(lines[3]), (lines[4]), Double.Parse(lines[5])));
                                break;
                            case "prices":
                                if (lines[0].ToLower() == "goat milk price") { Utility.goatMilkPrice = Double.Parse(lines[1]); }
                                if (lines[0].ToLower() == "sheep wool price") { Utility.sheepWoolPrice = Double.Parse(lines[1]); }
                                if (lines[0].ToLower() == "water price") { Utility.waterPrice = Double.Parse(lines[1]); }
                                if (lines[0].ToLower() == "government tax per kg") { Utility.govTax = Double.Parse(lines[1]); }
                                if (lines[0].ToLower() == "jersy cow tax") { Utility.jerseyCowTax = Double.Parse(lines[1]); }
                                if (lines[0].ToLower() == "cow milk price") { Utility.cowMilkPrice = Double.Parse(lines[1]); }
                                break;
                        } } } } }

        // Requirement 1 - Search for Animal Details using unique ID
        private void searchID()
        {
            int idSearch;
            bool isValid = true;
            bool exists = false;
            //Int32.TryParse(QueryInput.Text, out idSearch);
            isValid = Int32.TryParse(QueryInput.Text, out idSearch);

            foreach (KeyValuePair<int, Animal> entry in Dictionary.animalDictionary)
            {
                if(!isValid)
                {
                    QueryOutput.AppendText("Invalid input.");
                    break;
                }
                if (entry.Key == idSearch)
                {
                    exists = true;
                    QueryOutput.AppendText(entry.Value.getAnimalDetails());
                }
                else if (exists == false)
                {
                    QueryOutput.AppendText("Could not find ID.");
                    break;
                }
            }
        }


        // Requirement 2 - Display the total profit or loose of farm per day
        private void profitFarm()
        {
            double profit = 0;
            foreach (KeyValuePair<int, Animal> entry in Dictionary.animalDictionary)
            {
                profit += entry.Value.getProfit();
            }
            Profit.Text = String.Format("$ {0:n}", profit.ToString("#.##"));
        }


        // Requirement 3 - Total tax paid to the government per month
        private void govTax()
        {
            double tax = 0;
            foreach (KeyValuePair<int, Animal> entry in Dictionary.animalDictionary)
            {
                tax += entry.Value.getTax();
            }
            Tax.Text = String.Format("$ {0:n}", tax.ToString("#.##"));
        }


        // Requirement 4 - Total amount of milk for cows and goats
        private void cgMilk()
        {
            double milkAmount = 0;
            foreach (KeyValuePair<int, Animal> entry in Dictionary.animalDictionary)
            {
                milkAmount += entry.Value.getcgMilk();
            }
            AmtMilk.Text = milkAmount.ToString();
        }


        //Requirement 5 - Average age of all animals (dogs are excluded) 
        private void averageAge()
        {
            int count = 0;
            int age = 0;
            foreach (KeyValuePair<int, Animal> entry in Dictionary.animalDictionary)
            {
                age += entry.Value.getAge();
                count++;
            }
            int avg = age / count;
            AvgAge.Text = avg.ToString();
        }


        //Requirement 6 - Display average profit of (Cows & Goats) vs (Sheep)
        private void cgsProfit()
        {
            double cowGoatProf = 0;
            double sheepProf = 0;
            double count = 0;
            double counter = 0;
            foreach (KeyValuePair<int, Animal> entry in Dictionary.animalDictionary)
            {
                if (entry.Value.ToString() == "A2_AccessDatabase.Cows") { cowGoatProf += entry.Value.getProf(); count++; }
                if (entry.Value.ToString() == "A2_AccessDatabase.Goats") { cowGoatProf += entry.Value.getProf(); count++; }
                if (entry.Value.ToString() == "A2_AccessDatabase.JerseyCow") { cowGoatProf += entry.Value.getProf(); count++; }
                if (entry.Value.ToString() == "A2_AccessDatabase.Sheep") { sheepProf += entry.Value.getProf(); counter++; }
            }
            double CG = (cowGoatProf / count);
            double S = (sheepProf / counter);
            AvgProfit.Text = String.Format("$ {0:n}", CG.ToString("#.##"));
            SheepProfit.Text = String.Format("$ {0:n}", S.ToString("#.##"));
        }

        //Requirement 7 - Ratio of Dog Costs vs Total Cost
        private void dogCost()
        {
            double sumOfDogC = 0;
            double totalCost = 0;
            double count = 0;
            double counter = 0;
            foreach (KeyValuePair<int, Animal> entry in Dictionary.animalDictionary)
            {
                if (entry.Value.ToString() == "A2_AccessDatabase.Dogs") 
                {
                    sumOfDogC += entry.Value.getDogTotalCost(); count++; 
                }
                else 
                {
                    totalCost += entry.Value.getDogTotalCost(); counter++; 
                }

            }
            double ttlCost = totalCost;
            double dogCost = sumOfDogC; 
            DogC.Text = String.Format("$ {0:n}", dogCost.ToString("#.##"));
            TotalC.Text = String.Format("$ {0:n}", ttlCost.ToString("#.##"));
        }
            //Requirement 9 - Display the ratio of livestock with the color red
            private void redLivestock()
            {
            int numOfRed = 0;
            foreach (KeyValuePair<int, Animal> entry in Dictionary.animalDictionary)
            {
                if (entry.Value.getRed().ToLower() == "red")
                {
                    numOfRed++;
                }
            }
            LivestockRed.Text = numOfRed.ToString();
        }


        //Requirement 10 - Display the total tax paid for Jersey Cows
        private void jerseyTax()
        {
            double jcTax = 0;
            foreach (KeyValuePair<int, Animal> entry in Dictionary.animalDictionary)
            {
                if (entry.Value.ToString() == "A2_AccessDatabase.JerseyCow") 
                {
                    jcTax += entry.Value.getJCowTax(); 
                }
            }
            JCowTax.Text = String.Format("$ {0:n}", jcTax.ToString("#.##"));
        }


        //Requirement 11 - The user enter a threshold (number of years), and the program displays the 
        //ratio of the number of animal farm where the age is above this threshold.
        private void aboveThreshold()
        {
            bool isNum = true;
            int count = 0;
            int inputAge;
            isNum = Int32.TryParse(ThresholdInput.Text, out inputAge);

            foreach (KeyValuePair<int, Animal> entry in Dictionary.animalDictionary)
            {
                if (!isNum)
                {
                    ThresholdOutput.Text = "Invalid input";
                    break;
                }
                else if (ThresholdInput.Text == "")
                {
                    ThresholdOutput.Text = "Input is null.";
                    break;
                }
                else if (entry.Value.Age > Int32.Parse(ThresholdInput.Text))
                {
                    count++;
                }
            ThresholdOutput.Text = count.ToString();
            }
        }


        //Requirement 12 - Display the total profitability of all Jersey Cows. 
        private void jerseyProfit()
        {
            double jcProfit = 0;
            foreach (KeyValuePair<int, Animal> entry in Dictionary.animalDictionary)
            {
                if (entry.Value.ToString() == "A2_AccessDatabase.JerseyCow") 
                {
                    jcProfit += entry.Value.getProf(); 
                }
            }
            JCowProfit.Text = String.Format("$ {0:n}", jcProfit.ToString("#.##"));
        }


        private void Confirm_Click_1(object sender, EventArgs e)
        {
            searchID(); //Req 1
            profitFarm(); //Req 2
            govTax(); //Req 3
            cgMilk(); //Req 4
            averageAge(); //Req 5
            cgsProfit(); //Req 6
            dogCost(); //Req 7
            redLivestock(); //Req 9
            jerseyTax(); //Req 10
            aboveThreshold(); //Req 11
            jerseyProfit(); //Req 12
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            QueryInput.Clear();
            QueryOutput.Clear();
            AvgAge.Clear();
            ThresholdInput.Clear();
            ThresholdOutput.Clear();
            Profit.Clear();
            Tax.Clear();
            AmtMilk.Clear();
            AvgProfit.Clear();
            DogC.Clear();
            TotalC.Clear();
            JCowTax.Clear();
            JCowProfit.Clear();
            LivestockRed.Clear();
            SheepProfit.Clear();
        }

        private void QueryInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}