using System;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Welcome to Pierre's Bakery online ordering!");
            Console.WriteLine("We are delighted to take your order for our delicious bread and pastries.");
            Console.WriteLine("A single loaf of our freshly made bread is priced at $5.00 each. We currently have a special offer - for every 2 loaves of bread purchased, you'll receive the 3rd loaf for free!");
            Console.WriteLine("A single decadent pastry is priced at $2.00 each. We currently have a special offer - for every 3 pastries purchased, you'll receive the 4th pastry for free!");
            Console.WriteLine("Please enter the number of loaves of bread you would like:");
            string stringNumLoafs = Console.ReadLine();
            Console.WriteLine("Please enter the number of pastries you would like:");
            string stringNumPastries = Console.ReadLine();
            int breadAmount = int.Parse(stringNumLoafs);
            int pastryAmount = int.Parse(stringNumPastries);

            double totalCost = CalculateTotalCost(breadAmount, pastryAmount);

            Console.WriteLine($"You've ordered {breadAmount} loaves of bread and {pastryAmount} pastries.");
            Console.WriteLine($"Your total cost is ${totalCost:F2}. Enjoy your order!");
        }

        static double CalculateTotalCost(int breadAmount, int pastryAmount)
        {
            Bread bread = new Bread { Quantity = breadAmount };
            Pastry pastry = new Pastry { Quantity = pastryAmount };

            double breadCost = bread.CalculateCost();
            double pastryCost = pastry.CalculateCost();

            // Calculate the total cost with any discounts
            double totalCost = breadCost + pastryCost;

            return totalCost;
        }
    }
}