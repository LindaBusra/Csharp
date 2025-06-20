public class Ebok : Bok
{
    public double FileSize { get; set; }

    //Initialiserer Ebok med ISBN, tittel, forfatter, sider, filstørrelse.
    public Ebok(string isbn, string title, string author, int pageNumber, double fileSize)
        : base(isbn, title, author, pageNumber)
    {
        FileSize = fileSize;
    }

    // Overskriver den arvede GetInfo()-metoden for å inkludere filstørrelsen
    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Filstørrelse: {FileSize} MB";
    }
}