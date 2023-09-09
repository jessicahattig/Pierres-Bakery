using System.Collections.Generic;

namespace PierresBakery.Models
{
    public class Pastry
    {
        public int Quantity { get; set; }

        public double CalculateCost()
        {
            int set = Quantity;
            double cost = set * 2;
            return cost;
        }
    }
}