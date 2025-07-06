public class CarService
{
    // Leser biler fra en CSV-fil og returnerer en liste av Car-objekter.
    public static List<Car> GetCarsFromCsv(string csvFile)
    {
        // Lagrer en ny liste for å holde Car-objekter
        List<Car> cars = new List<Car>();

        int lineNummer = 1;         // Legg til en teller for linjenummer.

        try
        {
            using (StreamReader sr = new StreamReader(csvFile))
            {
                sr.ReadLine();      //Ignorerer første linje som er en overskrift 
                string line;        //Den blir brukt til å holde på hver linje som StreamReader leser fra filen

                //Dette kode leser en linje fra en fil og fortsetter å lese til den leser null
                while ((line = sr.ReadLine()) != null)
                {
                    lineNummer++;   //Øk telleren for hver linje som leses.
                    string[] parts = line.Split(',');

                    if (parts.Length == 5)
                    {
                        try
                        {
                            Car car = new Car       // Oppretter en Car-objekt fra CSV-linjen.
                            {
                                Model = parts[0],
                                Year = int.Parse(parts[1]),
                                Color = parts[2],
                                Mileage = int.Parse(parts[3]),
                                Price = int.Parse(parts[4])
                            };

                            //legger det nye Car-objektet til i lista
                            cars.Add(car);
                        }
                        catch (FormatException ex)
                        {
                            // Når en formatfeil oppdages, vis linjenummeret og feilmeldingen til brukeren.
                            Console.WriteLine($"Linje {lineNummer}: Formatfeil - {ex.Message}");
                        }
                    }
                    else
                    {
                        //Håndtere situasjoner der en linje i CSV-filen ikke inneholder nøyaktig fem elementer
                        Console.WriteLine($"Linje {lineNummer}: Linjen har for få eller for mange data: {line}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            //Forteller brukeren hva som skjedde uten at hele programmet stopper eller krasjer
            Console.WriteLine($"En feil oppsto: {ex.Message}");
        }
        return cars;
    }
}
