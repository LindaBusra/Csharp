
/*
//Fin alle elementer i en liste med tall som er større enn 10
List<int> tallListe = new List<int>(){1,5,7,8,12,15,20};

//bruk LinQ for å filtrerer lista med tall som er større enn 10

var tallStorreEnn10 =  tallListe.Where(tall => tall>10);
foreach (var tall in tallStorreEnn10)
{
    Console.WriteLine(tall);
}


//Finn gjennomsnitlisverdien av alle elementer i en liste med tall
List<int> tallListe1 = new List<int>(){1,2,3,4,5};
var gjennomsnitt = tallListe1.Average();
Console.WriteLine("Gjennomsnitt: " +  gjennomsnitt);



Dictionary<string, string> gulesider = new Dictionary<string, string>
{
    {"Frode", "123456789"},
    {"Stefan", "123654987"}
};

gulesider["Frode"] = "789523641";   


//Lag en generisk liste som kan lagre elementer av typen int og legg til 5 elementer i listen


        List<int> tallListe = new List<int>();

        // Legger til 5 elementer i listen
        tallListe.Add(1);
        tallListe.Add(2);
        tallListe.Add(3);
        tallListe.Add(4);
        tallListe.Add(5);
       foreach (int tall in tallListe)
        {
            Console.WriteLine(tall);
        }




//lag en generisk dictionary som kan lagre elementer av typene string og int ogg legg til 3 elementer i dictionary
//navn og alder

Dictionary<string, int> navnAlder = new Dictionary<string, int>();
navnAlder.Add("Frode", 12);
navnAlder.Add("Kari", 87);
navnAlder.Add("Ola", 56);
navnAlder.Add("Stevan", 36);


int alder  = navnAlder["Ola"];
Console.WriteLine(alder);
int FrodeAlder  = navnAlder["Frode"] = 45;

Console.WriteLine(FrodeAlder);


double avg = navnAlder.Values.Average();
Console.WriteLine(avg); 


// Forskjellige metoder i LINQ

// Select

using System.Reflection.Metadata.Ecma335;

List<int> tallListe = new List<int>(){1,2,3,4,5};

var dobbelListe = tallListe.Select(tall => tall*2);

foreach (var tall in dobbelListe)
{
    Console.WriteLine("tall: "+tall);
}







//LAmbda utrykk for å finne tall større enn 10
List<int> tallListe  = new List<int>{1,5,8,12,15,20};

var tallStorreEnn10 = tallListe.Where(tall => tall > 10);

foreach( var tall in tallStorreEnn10) {
    Console.WriteLine ("tall : " + tall);
}

//Delegate som refererer til lambda utrykket
Func<int, bool> erStorreEnn10 =  tall => tall > 10; 


foreach( var tall in tallListe) {
    if(erStorreEnn10 (tall))
    {
        Console.WriteLine($"{tall} er større enn 10");
    }
}

*/



public delegate int BeregnSumDelegate(int a, int b);




public class Program
{
    public delegate int BeregnSumDelegate(int a, int b);

    public static int Sum(int a, int b)
    {
        return a + b;
    }


    private static void Main(string[] args)
    {
        BeregnSumDelegate beregnSum = Sum;
        int resultat = beregnSum(5, 10);

        BeregnSumDelegate beregnSumLambda = (a, b) => a + b;

        resultat = beregnSumLambda(5, 10);

        Console.WriteLine("resultat : " + resultat);
    }
}

















/*



Console.WriteLine("Testten gelen: " + 15);

Dictionary<string, int> ansattesAlder = new Dictionary<string, int>
{
    {"Anna", 28},
    {"Bjørn", 35}
};

// Anahtarın doğru yazıldığına emin olun
int alder = ansattesAlder["Anna"];
Console.WriteLine(alder);  */


