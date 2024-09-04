using Object_Oriented;

Vehicle car1 = new Car("ABC123", "Toyota", "Camry", 50.0, "Sedan");
Vehicle truck1 = new Truck("XYZ789", "Ford", "F-150", 75.0, 500);

ICustomer customer1 = new RegularCustomer("John Doe");
ICustomer customer2 = new CorporateCustomer("Acme Corp");

customer1.RentVehicle(car1, 3);
customer2.RentVehicle(truck1, 5);

Console.WriteLine("\nRented Vehicles for Regular Customer:");
foreach (var vehicle in customer1.GetRentedVehicles())
{
    Console.WriteLine($"- {vehicle.GetModel()}");
}

Console.WriteLine("\nRented Vehicles for Corporate Customer:");
foreach (var vehicle in customer2.GetRentedVehicles())
{
    Console.WriteLine($"- {vehicle.GetModel()}");
}