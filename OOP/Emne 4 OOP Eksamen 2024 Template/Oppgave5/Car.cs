
public class Car
{
    // Egenskaper for bilen: modell, årstall, farge, km stand, pris. Disse egenskapene settes når en ny car lages             
    public string Model { get; set; } // Modell av bilen.
    public int Year { get; set; } // Årstall for bilen.
    public string Color { get; set; } // Farge på bilen.
    public int Mileage { get; set; } // Kilometerstand for bilen.
    public int Price { get; set; } // Pris på bilen.



    // Overrider ToString for å gi informasjon om bilens egenskaper.
    public override string ToString()
    {
        return $"Model: {Model}, Year: {Year}, Color: {Color}, Mileage: {Mileage}, Price: {Price}";
    }
}
