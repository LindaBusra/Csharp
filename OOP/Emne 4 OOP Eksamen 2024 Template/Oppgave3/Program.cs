// Oppgave 3

class Program
{
    static void Main(string[] args)
    {

        //Oppretter liste med bok- og e-bok-objekter.
        List<Bok> boker = new List<Bok>
        {
            new Bok("900-11-21-01", "Sult", "Knut Hamsun", 100),
            new Bok("900-11-21-02", "Ut og stjæle hester", "Per Petterson", 150),
            new Bok("900-11-21-03", "Sofies verden", "Jostein Gaarder", 200),
            new Bok("900-11-21-04", "De usynlige", "Roy Jacobsen", 250),
            new Bok("900-11-21-05", "Berlinerpoplene", "Anne B. Ragde", 300),
            new Ebok("900-11-21-06", "Tante Ulrikkes vei", "Zeshan Shakar", 120, 1.5),
            new Ebok("900-11-21-07", "Et lite stjerneteppe", "Cathrine Knudsen", 130, 2.0),
            new Ebok("900-11-21-08", "Hvite niggere", "Ingvar Ambjørnsen", 140, 2.5),
            new Ebok("900-11-21-09", "Kongens nei", "Alf R. Jacobsen", 150, 3.0),
            new Ebok("900-11-21-10", "Bienes historie", "Maja Lunde", 160, 3.5)

        };

        //Skriver ut informasjon om hver bok i listen.
        foreach (var bok in boker)
        {
            Console.WriteLine(bok.GetInfo());
        }

        CalculateTotalFileSize(boker);
    }



    //Beregner den totale filstørrelsen for alle e-bøkene, og skriver resultatet til konsollen.

    static void CalculateTotalFileSize(List<Bok> boker)
    {
        double totalSize = 0;
        foreach (var bok in boker)
        {
            if (bok is Ebok ebok)
            {
                totalSize += ebok.FileSize;
            }
        }
        Console.WriteLine($"Total filstørrelse for alle e-bøker: {totalSize} MB");
    }
}