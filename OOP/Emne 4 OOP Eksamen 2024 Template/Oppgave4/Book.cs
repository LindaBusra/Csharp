
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Book : IFormattable
{    

    //Disse egenskapene settes når en ny bok lages
    public string ISBN { get; init; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageCount { get; private set; }


    //Setter ISBN, tittel, forfatter og sidetall når en ny bok opprettes
    public Book(string isbn, string title, string author, int pageCount)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
        PageCount = pageCount;
    }



    //Returnerer bokens data som en informativ tekststreng
    public string GetInfo()
    {
        return $"ISBN: {ISBN} Title: {Title} Author: {Author} Page Count: {PageCount}\n";
    }



    // Konverterer bokobjektet til en CSV-streng.
    public string ToCSV()
    {
        return $"{ISBN},{Title.Replace(",", ";")},{Author.Replace(",", ";")},{PageCount}";
    }



    // Konverterer bokobjektet til en JSON-streng.
    public string ToJSON()
    {
        return JsonSerializer.Serialize(new { ISBN, Title, Author, PageCount });
    }
}