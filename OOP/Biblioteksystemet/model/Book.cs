
// Representerer en bok med grunnleggende egenskaper og en metode for å vise informasjon

public class Book
{
    public string Title { get; set; }               // Bokens tittel
    public string Author { get; set; }              // Navn til forfatter
    public string ISBN { get; set; }                // Boknummer eller bookID
    public bool IsCheckedOut { get; set; } = false; // For å holde styr på om boken er utlånt eller ikke


    // Konstruktør uten parameter, det brukes når vi oppretter en object fra den klassen
    public Book() { }                

    // Konstruktør med parametere for å initialisere en bok
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }


    // Method som viser bok informasjon
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Book - Title: {Title}, Author: {Author}, ISBN: {ISBN}");
    }


    // Overbelaster == operatøren for å sammenligne to bøker basert på ISBN
    public static bool operator ==(Book a, Book b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (ReferenceEquals(a, null)) return false;
        if (ReferenceEquals(b, null)) return false;
        return a.ISBN == b.ISBN;
    }
    

    // Overbelaster != operatøren
    public static bool operator !=(Book a, Book b) => !(a == b);

    // Overskriver Equals-metoden
    public override bool Equals(object obj) => this == obj as Book;

    // Overskriver GetHashCode-metoden
    public override int GetHashCode() => ISBN.GetHashCode();
}
