// Oppgave 2
class Program
{
    static void Main(string[] args)
    {
        // Setter opp et nytt Bok-eksemplar med definerte egenskaper
        Bok bok = new Bok("900-12-01-2024-1", "Bare et barn", "Sofia Strømsvold", 423);
        Console.WriteLine("Ny bok opprettet:");
        Console.WriteLine(bok.GetInfo());

        // Legger til sider i boken
        Console.WriteLine("\nLegger til 10 sider");
        bok.IncreasePageCount(10);
        Console.WriteLine(bok.GetInfo());

        // Fjerner sider fra boken
        Console.WriteLine("\nFjerner 60 sider");
        bok.DecreasePageCount(60); 
        Console.WriteLine(bok.GetInfo());
    }
}