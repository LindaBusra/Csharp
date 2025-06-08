namespace VehicleRegister_uke6.model;

public class Boat : Vehicle
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int Horsepower { get; set; }

    public Boat(string plateNumber, string brand, string model, int yearModel, double length, double width,
        int horsepower) : base(plateNumber, brand, model, yearModel)
    {
        Length = length;
        Width = width;
        Horsepower = horsepower;
    }
    
    public override void Start()
    {
        Console.WriteLine("Båten startet!");
    }

    public override void Stop()
    {
        Console.WriteLine("Båten stoppet!");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Lengde: {Length}");
        Console.WriteLine($"Bredde: {Width}");
        Console.WriteLine($"Hestekrafter: {Horsepower}");
    }

    public static Boat CreateBoat()
    {
        Console.Write("Skiltnummer: ");
        string plateNumber = Console.ReadLine();
        Console.Write("Merke: ");
        string brand = Console.ReadLine();
        Console.Write("Modell: ");
        string model = Console.ReadLine();
        Console.Write("Årsmodell: ");
        int yearModel = int.Parse(Console.ReadLine());
        Console.Write("Lengde: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Bredde: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Hestekrafter: ");
        int horsepower = int.Parse(Console.ReadLine());

        return new Boat(plateNumber, brand, model, yearModel, length, width, horsepower);
    }
}