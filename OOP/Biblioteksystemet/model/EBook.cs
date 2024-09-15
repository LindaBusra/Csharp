
// Representerer en e-bok, som arver fra Book classen

using System;

public class EBook : Book
{
    public string FilePath { get; set; }        // Filsti til e-bokens fil
    public string FileFormat { get; set; }      // Filformatet til e-boken


    // Konstruktør med parametere for å initialisere en e-bok
    public EBook(string title, string author, string isbn, string filePath, string fileFormat)
        : base(title, author, isbn)
    {
        FilePath = filePath;
        FileFormat = fileFormat;
    }


    // Overskriver DisplayInfo for å inkludere filsti og format
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"EBook - File Path: {FilePath}, File Format: {FileFormat}");
    }
}
