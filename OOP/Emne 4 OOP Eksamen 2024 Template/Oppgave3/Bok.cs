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



    // Funksjon for å vise bokens detaljer
    // GetInfo er virtual slik at den kan overskrives
    public virtual string GetInfo()
    {
        return $"Tittel: {Title}, Forfatter: {Author}, ISBN: {ISBN}, Antall sider: {PageNumber}";
    }
}


