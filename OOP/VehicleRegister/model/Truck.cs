public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Kjøretøy: Lastebil, {PlateNumber}, {Brand}, {Model}, {YearModel}, Lastekapasitet: {LoadCapacity}");

    }

    public static Truck? CreateTruck()
    {
        try
        {
            Truck truck = new Truck();
            PopulateVehicleInformation(truck);

            Console.WriteLine("Lastekapasitet: ");
            if (!int.TryParse(Console.ReadLine(), out int loadCapacity))
            {
                Console.WriteLine("Ugyldig valg, prøv igjen!.");
                return null;
            }
            truck.LoadCapacity = loadCapacity;

            return truck;
        }
        catch (FormatException)
        {
            Console.WriteLine("Ugyldig valg, prøv igjen!.");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Det er et problem: {ex.Message}");
            return null;
        }
    }
}
