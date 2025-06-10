
using VehicleRegister_uke6.model;
using VehicleRegister_uke6.service;

var vehicleService = new VehicleService();

while (true)
{
    Console.WriteLine("***************************");
    Console.WriteLine("1. Legg til bil!");
    Console.WriteLine("2. Legg til lastebil!");
    Console.WriteLine("3. Legg til motorsykkel!");
    Console.WriteLine("4. Legg til boat!");
    Console.WriteLine("5. Vis alle kjøretøy!");
    Console.WriteLine("6. Avslutt!");
    Console.WriteLine("***************************");

    Console.Write("Ditt valg: ");
    string choice = Console.ReadLine();
    
    switch (choice)
    {
        case "1":
            Console.WriteLine("Vennligst skriv inn informasjonen nedenfor for å registrere bilen");
            vehicleService.AddVehicle(Car.CreateCar());
            break;
        case "2":
            Console.WriteLine("Vennligst skriv inn informasjonen nedenfor for å registrere lastebilen");
            vehicleService.AddVehicle(Truck.CreateTruck());
            break;
        case "3":
            Console.WriteLine("Vennligst skriv inn informasjonen nedenfor for å registrere motorsykkelen");
            vehicleService.AddVehicle(Motorcycle.CreateMotorcycle());
            break;
        case "4":
            Console.WriteLine("Vennligst skriv inn informasjonen nedenfor for å registrere båten");
            vehicleService.AddVehicle(Boat.CreateBoat());
            break;
        case "5":
            vehicleService.ShowVehicles();
            break;
        case "6":
            Console.WriteLine("--- BYE ---");
            return;
        default:
            Console.WriteLine("Ugyldig valg, prøv igjen!");
            break;
    }
}



