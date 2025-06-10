using VehicleRegister_uke6.interfaces;

namespace VehicleRegister_uke6.model;

public abstract class Vehicle : IVehicle
{
    public string PlateNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int YearModel { get; set; }

    public Vehicle(string plateNumber, string brand, string model, int yearModel)
    {
        PlateNumber = plateNumber;
        Brand = brand;
        Model = model;
        YearModel = yearModel;
    }

    public abstract void Start();
    public abstract void Stop();

    public virtual string GetVehicleInfo()
    {
        return $"Skiltnummer: {PlateNumber}, Merke: {Brand}, Model: {Model}, Årsmodel: {YearModel}";
    }

    // public bool IsVehicleRegistered(Vehicle vehicle)
    // {
    //     if (vehicle.PlateNumber.Length > 0)
    //         return true;
    //
    //     return false;
    // }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("-----------------------------------------------");
        // Console.WriteLine($"Kjøretøy: {PlateNumber}, {Brand}, {Model}, {YearModel}");
        Console.WriteLine(GetVehicleInfo());
    }
}