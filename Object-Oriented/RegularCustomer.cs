using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class RegularCustomer : ICustomer
    {
        private string name;
        private List<Vehicle> rentedVehicles;

        public RegularCustomer(string name)
        {
            this.name = name;
            rentedVehicles = new List<Vehicle>();
        }

        public string GetName()
        {
            return name;
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            rentedVehicles.Add(vehicle);
            double cost = vehicle.CalculateRentalCost(days);
            
            Console.WriteLine($"{name} rented {vehicle.GetMake()} {vehicle.GetModel()} for {days} days. Total cost: {cost}");
        }

        public List<Vehicle> GetRentedVehicles()
        {
            return rentedVehicles;
        }
    }
}
