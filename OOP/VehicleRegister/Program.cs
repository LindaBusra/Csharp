using System;

class Program
{
    static void Main(string[] args)
    {
        var vehicleService = new VehicleService();

        while (true)
        {
            Console.WriteLine("1. Legg til bil!");
            Console.WriteLine("2. Legg til lastebil!");
            Console.WriteLine("3. Legg til motorsykkel!");
            Console.WriteLine("4. Legg til båt!");
            Console.WriteLine("5. Vis alle kjøretøy!");
            Console.WriteLine("6. Avslutt!");

            string? choice = Console.ReadLine(); // for å gjøre det nullable ? 

            switch (choice)
            {
                case "1":
                    Car? car = Car.CreateCar();
                    if (car != null)
                        vehicleService.AddVehicle(car);
                    break;
                case "2":
                    Truck? truck = Truck.CreateTruck();
                    if (truck != null)
                        vehicleService.AddVehicle(truck);
                    break;
                case "3":
                    Motorcycle? motorcycle = Motorcycle.CreateMotorcycle();
                    if (motorcycle != null)
                        vehicleService.AddVehicle(motorcycle);
                    break;
                case "4":
                    Boat? boat = Boat.CreateBoat();
                    if (boat != null)
                        vehicleService.AddVehicle(boat);
                    break;
                case "5":
                    vehicleService.ShowVehicles();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Ugyldig valg, prøv igjen!");
                    break;
            }
        }
    }
}
