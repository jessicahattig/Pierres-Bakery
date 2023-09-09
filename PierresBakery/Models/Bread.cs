using System.Collections.Generic;

namespace PierresBakery.Models
{
    public class Bread
    {
        public int Quantity { get; set; }

        public double CalculateCost()
        {
            int set = Quantity;
            double cost = set * 5;
            return cost;
        }
    }
}