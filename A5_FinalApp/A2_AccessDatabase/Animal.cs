using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace A2_AccessDatabase
{
    public class Animal
    {
        // Requirement 1: Animal Details
        public virtual string getAnimalDetails() { return null; }

        // Requirement 2: Profit
        public virtual double getProfit() { return 0; }

        // Requirement 3: Government Tax
        public virtual double getTax() { return 0; }

        // Requirement 4: Cow and Goat Milk per day
        public virtual double getcgMilk() { return 0; }

        // Requirement 5: Average age of all animals
        public virtual int getAge() { return 0; }

        // Requirement 6: Average profitability of Goat and Cow
        public virtual double getProf() { return 0; }

        //Requirement 7: Dog Cost
        public virtual double getDogTotalCost() { return 0; }

        //Requirement 9: Number of animals color Red
        public virtual string getRed() { return ""; }

        // Requirement 10: Jersey Cow Tax
        public virtual double getJCowTax() { return 0; }

        


        //ID
        int animalID;
        public int ID
        {
            get { return animalID; }
            set { animalID = value; }
        }


        //Amount of Water
        double animalWater;
        public double AmountOfWater
        {
            get { return animalWater; }
            set { animalWater = value; }
        }


        //Daily Cost
        double animalCost;
        public double DailyCost
        {
            get { return animalCost; }
            set { animalCost = value; }
        }


        //Weight
        double animalWeight;
        public double Weight
        {
            get { return animalWeight; }
            set { animalWeight = value; }
        }


        //Age
        int animalAge;
        public int Age
        {
            get { return animalAge; }
            set { animalAge = value; }
        }

        //Animal
        public Animal() { }

        public Animal(int id, double amountWater, double weight, int age, string color, double dailyCost)
        {
            this.animalID = id;
            this.animalWater = amountWater;
            this.animalWeight = weight;
            this.animalAge = age;
            this.animalCost = dailyCost;
        }
    }
}
