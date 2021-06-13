using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_AccessDatabase
{
    class Sheep : Animal
    {
        //Requirement 1
        public override string getAnimalDetails()
        {
            string details = "Animal Type: Sheep |" + " ID: " + ID + " | Weight: " + Weight + " | Amount of Water: " + AmountOfWater +
                    " | Daily Cost: " + DailyCost + " | Age: " + Age + " | Colour: " + Color + " | Amount of Wool: " + animalWool;
            return details;
        }

        //Requirement 2
        public override double getProfit()
        {
            double tax = Weight * Utility.govTax;
            double wateramt = AmountOfWater * Utility.waterPrice;
            double income = animalWool * Utility.sheepWoolPrice;

            return income - (tax + DailyCost + wateramt);
        }

        //Requirement 3
        public override double getTax()
        {
            double tax = Weight * Utility.govTax;
            double income = animalWool * Utility.cowMilkPrice;
            return (tax * income) * 30;
        }

        //Requirement 5
        public override int getAge() { return Age; }

        //Requirement 7
        public override double getDogTotalCost() { return (AmountOfWater * Utility.waterPrice) + DailyCost + (Weight * Utility.govTax); }

        //Requirement 9
        public override string getRed() { return animalColor; }

        //Requirement 6
        public override double getProf()
        {
            double tax = Weight * Utility.govTax;
            double wateramt = AmountOfWater * Utility.waterPrice;
            double income = animalWool * Utility.sheepWoolPrice;

            return income - (tax + DailyCost + wateramt);
        }






        //Color
        string animalColor;
        public string Color
        {
            get { return animalColor; }
            set { animalColor = value; }
        }

        //Sheep Wool
        public double animalWool;
        public double wool
        {
            get { return animalWool; }
            set { animalWool = value; }
        }

        public Sheep(int id, double amountWater, double dailyCost, double weight, int age, string color, double woolAmount)
        {
            this.ID = id;
            this.AmountOfWater = amountWater;
            this.DailyCost = dailyCost;
            this.Weight = weight;
            this.Age = age;
            this.animalColor = color;
            this.animalWool = woolAmount;
        }
    }
}
