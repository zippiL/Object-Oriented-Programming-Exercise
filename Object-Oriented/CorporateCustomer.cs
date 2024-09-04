using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class CorporateCustomer : ICustomer
    {
        private string companyName;
        private List<Vehicle> rentedVehicles;
        private double discountRate = 0.1;
        public CorporateCustomer(string companyName)
        {
            this.companyName = companyName;
            rentedVehicles = new List<Vehicle>();
        }

        public string GetName()
        {
            return companyName;
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            double rentalCost = vehicle.CalculateRentalCost(days);
            double discountedCost = rentalCost * (1 - discountRate);
            rentedVehicles.Add(vehicle);
            Console.WriteLine($"{companyName} rented {vehicle.GetMake()} {vehicle.GetModel()} for {days} days. Cost after discount: {discountedCost}");
        }

        public List<Vehicle> GetRentedVehicles()
        {
            return rentedVehicles;
        }
    }
}
