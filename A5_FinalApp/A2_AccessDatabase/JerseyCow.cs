using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_AccessDatabase
{
    class JerseyCow : Cows
    {
        //Requirement 1
        public override string getAnimalDetails()
        {
            string details = "Animal Type: Jersey Cow | " + " ID: " + ID + " | Weight: " + Weight + " | Amount of water: " + AmountOfWater +
                    " | Daily Cost: " + DailyCost + " | Age: " + Age + " | Colour: " + color + " | Amount of Milk: " + AmountOfMilk + " | Is Jersy: " + IsJersy;
            return details;
        }

        //Requirement 2
        public override double getProfit()
        {
            double tax = Weight * Utility.govTax;
            double wateramt = AmountOfWater * Utility.waterPrice;
            return 0 - (tax + DailyCost + wateramt);
        }

        //Requirement 3
        public override double getTax()
        {
            double tax = Weight * Utility.govTax;
            double income = AmountOfMilk * Utility.cowMilkPrice;
            return (tax * income) * 30;

        }

        //Requirement 5
        public override int getAge() { return Age; }

        //Requirement 6
        public override double getProf()
        {
            double tax = Weight * Utility.jerseyCowTax;
            double wateramt = AmountOfWater * Utility.waterPrice;
            double income = AmountOfMilk * Utility.cowMilkPrice;

            return income - (tax + DailyCost + wateramt);
        }

        //Requirement 7
        public override double getDogTotalCost()
        {
            return (AmountOfWater * Utility.waterPrice) + DailyCost + (Weight * Utility.govTax);
        }

        //Requirement 10
        public override double getJCowTax()
        {
            return Weight * Utility.jerseyCowTax;
        }
       
        //Boolean is Jersey
        bool animalJersy;
        public bool IsJersy
        {
            get { return animalJersy; }
            set { animalJersy = value; }
        }

        public JerseyCow(int id, double amountWater, double dailyCost, double weight, int age, string color, double milkAmount, bool ij) : base(id, amountWater, dailyCost, weight, age, color, milkAmount, ij)
        {
            this.ID = id;
            this.AmountOfWater = amountWater;
            this.DailyCost = dailyCost;
            this.Weight = weight;
            this.Age = age;
            this.color = color;
            this.AmountOfMilk = milkAmount;
            this.IsJersy = ij;
        }

        
    }
}
