public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Kjøretøy: Motorsykkel, {PlateNumber}, {Brand}, {Model}, {YearModel}, Sidevogn: {(HasSidecar ? "JA" : "NEI")}");

    }

    public static Motorcycle? CreateMotorcycle()
    {
        try
        {
            Motorcycle motorcycle = new Motorcycle();
            PopulateVehicleInformation(motorcycle);

            Console.WriteLine("Sidevogn: (Ja/Nei)");
            motorcycle.HasSidecar = Console.ReadLine()?.ToLower() == "ja";

            return motorcycle;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Det er et problem: {ex.Message}");
            return null;
        }
    }
}
