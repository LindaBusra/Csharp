public class EBook : Book
{
    public string FilePath { get; set; }
    public string FileFormat { get; set; }

    public EBook(string title, string author, string isbn, string filePath, string fileFormat)
        : base(title, author, isbn)
    {
        FilePath = filePath;
        FileFormat = fileFormat;
    }

    public override void PrintInformation()
    {
        base.PrintInformation();
        Console.WriteLine($"FilePath: {FilePath}, FileFormat: {FileFormat}");
    }

}