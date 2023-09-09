using System.Collections.Generic;

namespace PierresBakery.Models
{
    public class Pastry
    {
        public int Quantity { get; set; }

        public double CalculateCost()
        {
            int setsOfFour = Quantity / 4;
            int remaining = Quantity % 4;
            double cost = (setsOfFour * 3 + remaining) * 2;
            return cost;
        }
    }
}