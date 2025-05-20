using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Numerics;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public static int BookCount = 0;

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        BookCount++;
    }

    public virtual void PrintInformation()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
    }

    public static bool operator ==(Book a, Book b)
    {
        return a.ISBN == b.ISBN;
    }

    public static bool operator !=(Book a, Book b)
    {
        return !(a == b);
    }
}