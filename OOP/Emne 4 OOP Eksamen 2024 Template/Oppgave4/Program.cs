using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        List<IFormattable> books = new List<IFormattable>();

        // Legger til bøker i listen.
        books.Add(new Book("900-11-21-01", "Sult", "Knut Hamsun", 100));
        books.Add(new Book("900-11-21-02", "Ut og stjæle hester", "Per Petterson", 150));
        books.Add(new Book("900-11-21-03", "Sofies verden", "Jostein Gaarder", 200));
        books.Add(new Book("900-11-21-04", "De usynlige", "Roy Jacobsen", 250));
        books.Add(new Book("900-11-21-05", "Berlinerpoplene", "Anne B. Ragde", 300));
        books.Add(new Book("900-11-21-06", "Tante Ulrikkes vei", "Zeshan Shakar", 120));
        books.Add(new Book("900-11-21-07", "Et lite stjerneteppe", "Cathrine Knudsen", 130));
        books.Add(new Book("900-11-21-08", "Hvite niggere", "Ingvar Ambjørnsen", 140));
        books.Add(new Book("900-11-21-09", "Kongens nei", "Alf R. Jacobsen", 150));
        books.Add(new Book("900-11-21-10", "Bienes historie", "Maja Lunde", 160));


        // Skriver alle bøkene i konsolen:
        foreach (var book in books)
        {
            Console.WriteLine(book.GetInfo());
        }

        string filePath = "book.csv";
        // Eksporterer bøker til en CSV-fil.
        if (ExportToCSV(books, filePath))
        {
            Console.WriteLine("Bøkene ble eksportert til CSV filen vellykket.");
        }
        else
        {
            Console.WriteLine("Det oppsto en feil under eksporteringen til CSV filen.");
        }
    }

    // Eksporterer en liste av IFormattable objekter til en CSV-fil.
    public static bool ExportToCSV(List<IFormattable> items, string filePath)
    {
        try
        {
            using (var streamWriter = new StreamWriter(filePath, false, new System.Text.UTF8Encoding(true)))
            {
                foreach (var item in items)
                {
                    streamWriter.WriteLine(item.ToCSV());
                }
            }
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bir hata oluştu: " + ex.Message);
            return false;
        }
    }
}