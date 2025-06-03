
//Oppgave 1: Ny Subklasse - Boat 
public class Boat : Vehicle
{
    public int Lengde { get; set; }
    public int Bredde { get; set; }
    public int Hestekrefter { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();;
        Console.WriteLine($"Kjøretøy: Båt, {PlateNumber}, {Brand}, {Model}, {YearModel}, Lengde: {Lengde}, Bredde: {Bredde}, Hestekrefter: {Hestekrefter}");

    }

//Oppgave 2: Implementer CreateBoat Metoden 
    public static Boat? CreateBoat()
    {
        try
        {
            Boat boat = new Boat();
            PopulateVehicleInformation(boat);

            Console.WriteLine("Lengde: ");
            if (!int.TryParse(Console.ReadLine(), out int lengde))
            {
                Console.WriteLine("Ugyldig valg, prøv igjen!.");
                return null;
            }
            boat.Lengde = lengde;

            Console.WriteLine("Bredde: ");
            if (!int.TryParse(Console.ReadLine(), out int bredde))
            {
                Console.WriteLine("Ugyldig valg, prøv igjen!.");
                return null;
            }
            boat.Bredde = bredde;

            Console.WriteLine("Hestekrefter: ");
            if (!int.TryParse(Console.ReadLine(), out int hestekrefter))
            {
                Console.WriteLine("Ugyldig valg, prøv igjen!.");
                return null;
            }
            boat.Hestekrefter = hestekrefter;

            return boat;
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
