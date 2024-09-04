using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public interface ICustomer
    {
        string GetName();
        void RentVehicle(Vehicle vehicle, int days);
        List<Vehicle> GetRentedVehicles();
    }
}
