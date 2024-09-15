using System;

class Program
{
    // Statisk referanse til biblioteket, som holder alle bøker.
    static Library<Book> library = new Library<Book>();

    static void Main(string[] args)
    {

        // Filsti for lagring av bibliotekdata.
        string filePath = "library.txt";

        // Sjekker om filen eksisterer, oppretter den hvis den ikke gjør det.
        if (!File.Exists(filePath))
        {
            // Opprett filen hvis den ikke eksisterer
            File.Create(filePath).Close();
        }


        library.LoadFromFile(filePath); // Last inn eksisterende bibliotek fra fil 


        // While funksjonen som brukeren kan utføre forskjellige operasjoner til brukeren vil avslutte
        while (true)
        {
            Console.WriteLine("\nVelg en operasjon:");
            Console.WriteLine("1. Legg til en bok");
            Console.WriteLine("2. Søk etter en bok");
            Console.WriteLine("3. Sjekk ut en bok");
            Console.WriteLine("4. Returner en bok");
            Console.WriteLine("5. Vis alle bøker");
            Console.WriteLine("6. Fjern en bok fra biblioteket");
            Console.WriteLine("7. Lagre og avslutt");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    SearchForBook();
                    break;
                case "3":
                    CheckoutBook();
                    break;
                case "4":
                    ReturnBook();
                    break;
                case "5":
                    ShowAllBooks();
                    break;
                case "6":
                    RemoveBook();
                    break;
                case "7":
                    library.SaveToFile("library.txt");  // Lagrer bibliotekets nåværende tilstand til filen og avslutter programmet
                    return;
                default:
                    Console.WriteLine("Ugyldig valg, vennligst prøv igjen.");
                    break;
            }
        }
    }


    // Legger til en ny bok i biblioteket.
    static void AddBook()
    {
        Console.WriteLine("Skriv inn tittel:");
        string title = Console.ReadLine();
        Console.WriteLine("Skriv inn forfatter:");
        string author = Console.ReadLine();
        Console.WriteLine("Skriv inn ISBN:");
        string isbn = Console.ReadLine();

        // Oppretter en ny bok og forsøker å legge den til i biblioteket
        var newBook = new Book(title, author, isbn);
        bool isAdded = library.AddItem(newBook);

        if (!isAdded)
        {
            Console.WriteLine("En bok med denne ISBN finnes allerede i biblioteket.");
        }
        else
        {

            Console.WriteLine("Bok lagt til biblioteket.");

        }
    }


    // Søker etter bøker basert på tittel
    static void SearchForBook()
    {
        Console.WriteLine("Skriv inn tittel for å søke:");
        string title = Console.ReadLine();

        library.DisplayItems(book => book.Title.Contains(title));
    }


    // Lar brukeren sjekke ut en bok basert på ISBN
    static void CheckoutBook()
    {
        Console.WriteLine("Skriv inn ISBN for boken du vil sjekke ut:");
        string isbn = Console.ReadLine();
        var book = library.FindItem(b => b.ISBN == isbn);
        if (book != null)
        {
            library.CheckoutItem(book);
            Console.WriteLine($"{book.Title} har blitt sjekket ut.");
        }
        else
        {
            Console.WriteLine("Boken finnes ikke i biblioteket.");
        }
    }


    // Lar brukeren returnere en bok basert på ISBN
    static void ReturnBook()
    {
        Console.WriteLine("Skriv inn ISBN for boken du vil returnere:");
        string isbn = Console.ReadLine();
        var book = library.FindItem(b => b.ISBN == isbn);
        if (book != null)
        {
            library.ReturnItem(book);
            Console.WriteLine($"{book.Title} har blitt returnert.");
        }
        else
        {
            Console.WriteLine("Boken finnes ikke i biblioteket.");
        }
    }


    // Viser alle bøker som er tilgjengelige i biblioteket
    static void ShowAllBooks()
    {
        Console.WriteLine("Alle bøker i biblioteket:");
        library.DisplayItems();
    }



    static void RemoveBook()
    {
        Console.WriteLine("Skriv inn ISBN for boken du ønsker å fjerne:");
        string isbn = Console.ReadLine();
        bool isRemoved = library.RemoveItem(isbn);
        if (!isRemoved)
        {
            Console.WriteLine("Kunne ikke fjerne boken. Sjekk om ISBN er korrekt og prøv igjen.");
        }
    }
}

