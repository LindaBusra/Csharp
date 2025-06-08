namespace VehicleRegister_uke6.model;

public class Car : Vehicle
{
    public int Seats { get; set; }

    public Car(string plateNumber, string brand, string model, int yearModel, int seats) : base(plateNumber, brand,
        model, yearModel)
    {
        Seats = seats;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Antallster: {Seats}");
    }

    public override void Start()
    {
        Console.WriteLine("Bilen startet!");
    }

    public override void Stop()
    {
        Console.WriteLine("Bilen stoppet!");
    }

    public string GetPlateNumber(Car car)
    {
        return car.PlateNumber;
    }

    public static Car CreateCar()
    {
        Console.Write("Skiltnummer: ");
        string plateNumber = Console.ReadLine();
        Console.Write("Merke: ");
        string brand = Console.ReadLine();
        Console.Write("Modell: ");
        string model = Console.ReadLine();
        Console.Write("Årsmodell: ");
        int yearModel = int.Parse(Console.ReadLine());
        Console.Write("Antallseter: ");
        int seats = int.Parse(Console.ReadLine());

        return new Car(plateNumber, brand, model, yearModel, seats);
    }
}