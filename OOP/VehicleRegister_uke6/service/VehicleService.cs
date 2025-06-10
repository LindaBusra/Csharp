using VehicleRegister_uke6.model;

namespace VehicleRegister_uke6.service;

public class VehicleService
{


    List<Vehicle> vehicles = new List<Vehicle>();


    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }


    public void ShowVehicles()
    {
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayInfo();
        }

  
    }
}