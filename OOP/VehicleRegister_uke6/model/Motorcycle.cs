namespace VehicleRegister_uke6.model;

public class Motorcycle : Vehicle
{

    public bool HasSidecar { get; set; }

    public Motorcycle(string plateNumber, string brand, string model, int yearModel, bool hasSidecar) : base(plateNumber, brand, model, yearModel)
    {
        HasSidecar = hasSidecar;
    }
    
    public override void Start()
    {
        Console.WriteLine("Motorsykkelen startet!");
    }

    public override void Stop()
    {
        Console.WriteLine("Motorsykkelen stoppet!");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Sidevogn: {(HasSidecar ? "JA" : "NEI")}");
    }

    public static Motorcycle CreateMotorcycle()
    {
        Console.Write("Skriv inn skiltnummer: ");
        string plateNumber = Console.ReadLine();
        Console.Write("Brand: ");
        string brand = Console.ReadLine();
        Console.Write("Modell: ");
        string model = Console.ReadLine();
        Console.Write("Årsmodel: ");
        int yearModel = int.Parse(Console.ReadLine());
        Console.Write("Sidevogn: ");
        bool sideCar = Console.ReadLine().ToLower() == "ja";

        return new Motorcycle(plateNumber, brand, model, yearModel, sideCar);
    }

    
}