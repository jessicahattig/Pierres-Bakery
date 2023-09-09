using System.Collections.Generic;

namespace PierresBakery.Models
{
    public class Bread
    {
        public int Quantity { get; set; }

        public double CalculateCost()
        {
            int setsOfThree = Quantity / 3;
            int remaining = Quantity % 3;
            double cost = (setsOfThree * 2 + remaining) * 5;
            return cost;
        }
    }
}