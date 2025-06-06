public abstract class Vehicle
{
    public string PlateNumber { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int YearModel { get; set; }

    public Vehicle()
    {
        PlateNumber = "";
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        //Console.WriteLine($"Kjøretøy: {PlateNumber}, {Brand}, {Model}, {YearModel}");
    }


    //Oppgave 3: Sentralisering av Create Metoder 
    protected static void PopulateVehicleInformation(Vehicle vehicle)
    {
        Console.WriteLine("Skiltnummer: ");
        vehicle.PlateNumber = Console.ReadLine() ?? ""; 

        Console.WriteLine("Merke: ");
        vehicle.Brand = Console.ReadLine();

        Console.WriteLine("Modell: ");
        vehicle.Model = Console.ReadLine();

        Console.WriteLine("Årsmodell: ");
        if (!int.TryParse(Console.ReadLine(), out int yearModel))
        {
            Console.WriteLine("Ugyldig valg, prøv igjen!.");
            return;
        }
        vehicle.YearModel = yearModel;
    }
}
