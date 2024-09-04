using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class Truck : Vehicle
    {
        private int capacity;

        public Truck(string licensePlate, string make, string model, double rentalPrice, int capacity)
            : base(licensePlate, make, model, rentalPrice)
        {
            this.capacity = capacity;
        }

        public override double CalculateRentalCost(int days)
        {
            double additionalCost = 0.1 * capacity*days; 
            return (days * rentalPrice) + additionalCost;
        }
    }

}
