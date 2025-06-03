public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Kjøretøy: Bil, {PlateNumber}, {Brand}, {Model}, {YearModel}, Antall seter: {Seats} ");

    }

    public static Car? CreateCar()
    {
        try
        {
            Car car = new Car();
            PopulateVehicleInformation(car);

            Console.WriteLine("Antall seter: ");
            if (!int.TryParse(Console.ReadLine(), out int seats))
            {
                Console.WriteLine("Ugyldig valg, prøv igjen!.");
                return null;
            }
            car.Seats = seats;

            return car;
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
