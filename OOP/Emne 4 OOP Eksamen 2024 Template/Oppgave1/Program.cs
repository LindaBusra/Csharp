
class Program
{
    static void Main()
    {

        Console.WriteLine("\n-------------------------------------------------Oppgave 1A-------------------------------------------------");
        string text = "Hi alle sammmen!";
        int age = 30;
        double price = 5.8;
        float weight = 55.5F;
        bool isStudent = false;
        char initial = 'L';


        // Skriv alle datatyper til konsollen ved bruk av en funksjon
        PrintVariableType("text", text);
        PrintVariableType("age", age);
        PrintVariableType("price", price);
        PrintVariableType("weight", weight);
        PrintVariableType("isStudent", isStudent);
        PrintVariableType("initial", initial);



        Console.WriteLine("\n-------------------------------------------------Oppgave 1B-------------------------------------------------");
        Console.WriteLine("Enter your sentence please:");
        string sentence = Console.ReadLine();
        // Skriv hvor mange ord en setning har ved bruk av en funksjon
        CountWordsInSentence(sentence);



        Console.WriteLine("\n-------------------------------------------------Oppgave 1C-------------------------------------------------");
        Console.WriteLine("Enter your sentence please:");
        string sentenceForReverse = sentence;
        // Skriv setningen som gis i OppgaveB baklengs
        ReverseString(sentenceForReverse);



        Console.WriteLine("\n-------------------------------------------------Oppgave 1D-------------------------------------------------");
        // Oppretter en array med 5 desimaltall
        double[] desimaltall = new double[] { 4.5, 6.7, 8.2, 9.3, 3.8 };
        // Kaller funksjonen for å skrive ut verdiene
        SkrivUtDesimaltall(desimaltall);


        Console.WriteLine("\n-------------------------------------------------Oppgave 1E-------------------------------------------------");
        // Kaller funksjonen for å skrive ut summen til elementene fra Oppgave 1D
        double result = CalculateSum(desimaltall);
        Console.WriteLine("Summen av tallene: " + result);


    }



    //For Oppgave 1A -  Funksjonen som skriver verdiene av variablene og deres tilhørende datatyper

    static void PrintVariableType<T>(string variableName, T variable)
    {
        //Skriver variabelnavn, typenavnet til T og verdien av variabelen til konsollen
        Console.WriteLine($"{variableName} is {typeof(T).Name} dataype and its value is : {variable}");
    }


    //For Oppgave 1B - Funksjonen som skriver ut antall ord i setningen
    static void CountWordsInSentence(string sentence)
    {
        if (!string.IsNullOrEmpty(sentence))
        {
            // Deler ord i en setning ved mellomrom og fjerner tomme elementer
            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Antall ord i din setning er: {words.Length} ");
        }
        else
        {
            Console.WriteLine("Du har ikke skrevet en setning!...");
        }
    }


    //For Oppgave 1C - Funksjonen som skriver en setning fra baklengs
    static void ReverseString(string sentence)
    {
        if (!string.IsNullOrEmpty(sentence))
        {
            //Deler setningen i ord og fjerner tomme elementer
            string[] wordsInSentence = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Reversed sentence: ");
            //Skriver en setning fra baklengs
            for (int i = wordsInSentence.Length - 1; i >= 0; i--)
            {
                Console.Write(wordsInSentence[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Du har ikke skrevet en setning!...");
        }
    }



    // For Oppgave 1D - Funksjon for å skrive ut elementer i en double-array
    static void SkrivUtDesimaltall(double[] arr)
    {
        //Skriver alle elementer i en array
        foreach (double tall in arr)
        {
            Console.WriteLine(tall);
        }
    }



    // For Oppgave 1E - Funksjon som bruker en for-løkke til å beregne summen
    static double CalculateSum(double[] arr)
    {
        //Beregner summen av elementene i en array
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
}