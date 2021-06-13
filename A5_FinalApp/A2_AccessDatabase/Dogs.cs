using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_AccessDatabase
{
    class Dogs : Animal
    {
        //Requirement 1
        public override string getAnimalDetails()
        {
            string details = "Animal Type: Dog |" + " ID: " + ID + " | Weight: " + Weight + " | Amount of water: " + AmountOfWater +
                    " | Daily Cost: " + DailyCost + " | Age: " + Age + " | Colour: " + color;
            return details;
        }

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

        public Dogs(int id, double amountWater, double weight, int age, string color, double dailyCost) : base(id, amountWater, weight, age, color, dailyCost)
        { 

            this.ID = id;
            this.AmountOfWater = amountWater;
            this.DailyCost = dailyCost;
            this.Weight = weight;
            this.Age = age;
            this.animalColor = color;
        }
    }
}
