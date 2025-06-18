using System;

public class Bok
{

    //Disse egenskapene settes når en ny bok lages
    private int _pageCount;

    public string ISBN { get; init; }
    public string Title { get; set; }
    public string Author { get; set; }

    public int PageNumber => _pageCount;


    // Konstruktøren for Bok-klassen som initialiserer nødvendig informasjon
    public Bok(string isbn, string title, string author, int pageNumber)
    {
        ISBN = isbn;               // Setter ISBN-nummeret til boken
        Title = title;             // Setter tittelen på boken
        Author = author;           // Setter forfatteren av boken
        _pageCount = pageNumber;   // Setter antall sider i boken
    }


    // Funksjon for å legge til flere sider i boken
    public void IncreasePageCount(int numberOfPages)
    {
        if (numberOfPages > 0)
        {
            _pageCount += numberOfPages;
        }
        else
        {
            Console.WriteLine("Sideantallet som skal legges til må være et positivt tall!");
        }
    }

    // Funksjon for å trekke fra sider i bok
    public void DecreasePageCount(int numberOfPages)
    {
        if (numberOfPages > 0 && numberOfPages <= _pageCount)
        {
            _pageCount -= numberOfPages;
        }
        else if (numberOfPages <= 0)
        {
            Console.WriteLine("Sideantallet som skal trekkes fra må være et positivt tall!");
        }
        else
        {
            Console.WriteLine("Antallet sider som fjernes kan ikke være mer enn bokens totale sidetall!");
        }
    }

    // Funksjon for å vise bokens detaljer
    public string GetInfo()
    {
        return $"Tittel: {Title}, Forfatter: {Author}, ISBN: {ISBN}, Antall sider: {PageNumber}";
    }
}


