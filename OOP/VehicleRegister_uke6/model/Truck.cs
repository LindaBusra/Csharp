namespace VehicleRegister_uke6.model;

public class Truck : Vehicle
{

    public int LoadCapacity { get; set; }

    public Truck(string plateNumber, string brand, string model, int yearModel, int loadCapacity) : base(plateNumber, brand, model, yearModel)
    {
        LoadCapacity = loadCapacity;
    }
    
    public override void Start()
    {
        Console.WriteLine("Lastebilen startet!");
    }

    public override void Stop()
    {
        Console.WriteLine("Lastebilen stoppet!");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Lastekapasitet: {LoadCapacity}");

    }


    public static Truck CreateTruck()
    {
        Console.Write("Skiltnummer: ");
        string plateNumber = Console.ReadLine();
        Console.Write("Merke: ");
        string brand = Console.ReadLine();
        Console.Write("Modell: ");
        string model = Console.ReadLine();
        Console.Write("Årsmodell: ");
        int yearModel = int.Parse(Console.ReadLine());
        Console.Write("Lastekapasitet: ");
        int loadCapacity = int.Parse(Console.ReadLine());

        return new Truck(plateNumber, brand, model, yearModel, loadCapacity);
    }
}