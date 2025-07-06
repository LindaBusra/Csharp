
class Program
{
    static void Main(string[] args)
    {
        // Filen ligger i prosjektet og blir automatisk kopiert til output slik at den kan brukes bare på filnavn!
        string fileName = "cars.csv";

        // Kaller 'GetCarsFromCsv' og skriver ut filtrerte biler.
        List<Car> cars = CarService.GetCarsFromCsv(fileName);

        // Skriv ut biler fra og med år 2020.
        Console.WriteLine("\n\n1-Alle biler fra og med årsmodell 2020 og nyere:\n");
        foreach (Car car in cars)
        {
            if (car.Year >= 2020)
            {
                Console.WriteLine(car);
            }
        }

        // Skriv ut biler med mindre enn 30000 kilometerstand.
        Console.WriteLine("\n\n2-Alle biler som har en kilometer stand mindre enn 30000:\n");
        foreach (Car car in cars)
        {
            if (car.Mileage < 30000)
            {
                Console.WriteLine(car);
            }
        }

        // Skriv ut biler med mindre enn 30000 km og kostnad mindre enn 100000 kr.
        Console.WriteLine("\n\n3-Alle biler har gått mindre enn 30000 km og koster mindre enn 100000 kroner:\n");
        foreach (Car car in cars)
        {
            if (car.Mileage < 30000 && car.Price < 100000)
            {
                Console.WriteLine(car);
            }
        }
    }
}