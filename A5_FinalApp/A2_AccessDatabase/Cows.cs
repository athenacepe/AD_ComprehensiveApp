using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_AccessDatabase
{
    public class Cows : Animal
    {

        // Requirement 1
        public override string getAnimalDetails()
        {
            string details = "Animal Type: Cow |" + " ID: " + ID + " | Weight: " + Weight + " | Amount of water: " + AmountOfWater +
                " | Daily Cost: " + DailyCost + " | Age: " + Age + " | Colour: " + color + " | Amount of Milk: " + AmountOfMilk;
            return details;
        }

        //Requirement 2
        public override double getProfit()
        {
            double tax = Weight * Utility.govTax;
            double wateramt = AmountOfWater * Utility.waterPrice;
            double income = AmountOfMilk * Utility.cowMilkPrice;
            
            return income - (tax + DailyCost + wateramt);
        }

        //Requirement 3
        public override double getTax()
        {
            double tax = Weight * Utility.govTax;
            double income = AmountOfMilk * Utility.cowMilkPrice;
            return (tax * income) * 30;
        }

        //Requirement 4
        public override double getcgMilk() { return AmountOfMilk; }

        // Requirement 5
        public override int getAge() { return Age; }

        //Requirement 7
        public override double getDogTotalCost() { return (AmountOfWater * Utility.waterPrice) + DailyCost + (Weight * Utility.govTax); }

        //Requirement 9
        public override string getRed() { return animalColor; }






        //Color
        string animalColor;
        public string color
        {
            get { return animalColor; }
            set { animalColor = value; }
        }

        //Milk
        double animalMilk;
        public double AmountOfMilk
        {
            get { return animalMilk; }
            set { animalMilk = value; }
        }

        //Boolean isJersy
        bool animalJersy;

        public Cows(int id, double amountWater, double dailyCost, double weight, int age, string color, double milkAmount, bool isJersy) : base(id, amountWater, weight, age, color, dailyCost)
        {
            this.ID = id;
            this.AmountOfWater = amountWater;
            this.DailyCost = dailyCost;
            this.Weight = weight;
            this.Age = age;
            this.animalColor = color;
            this.animalMilk = milkAmount;
            this.animalJersy = isJersy;
        }
    }
}
