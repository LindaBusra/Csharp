using System;
<<<<<<< HEAD
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        

        /*

//i eksamen we can ikke bruke absoluth path

//Read lines with using Array
string[] lines1 = File.ReadAllLines("minTekst.txt");

foreach (string line in lines1)
{
    Console.WriteLine(line);
}



//Read with StreamReader (linje by linje)  Her we can use if
            using (StreamReader reader = new StreamReader("minTekst.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if(line.Contains("Backend"))
                    {
                        Console.WriteLine(line + " hatt en fin dag");
                    } else {
                    Console.WriteLine(line);
                    }
                }
            }


//her den oppretter txt file seg selv
        using (StreamWriter writer = new StreamWriter("nyText.txt"))
        {
            writer.WriteLine("Dette er den 1. setningen.");
            writer.WriteLine("Dette er den 2. setningen.");
            writer.WriteLine("Dette er den 3. setningen.");
            writer.WriteLine("Dette er den 4. setningen.");
        }


// Filrelaterte feilhåndtering
try
{
    using (StreamReader reader = new StreamReader("ikkeEksisterendeFil.txt"))
    {
        Console.WriteLine(reader.ReadToEnd());
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine("Filen ble ikke funnet!");
}


*/



//Oppgave registrering og Søk av medlemmer   

string filePath = "members.txt";
if(!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

while (true)
{
    Console.WriteLine("Velg en operasjon:");
    Console.WriteLine("1. Registrer ny medlem");
    Console.WriteLine("2. Søk for en medlem");
    Console.WriteLine("3. Exit");

    string option = Console.ReadLine();

    switch (option)
    {
        case "1": 
            RegisterMember();
            break;
        case "2": 
            SearchForMember();
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Ugyldig operasjon, vennligst prøv igjen.");
            break;
    }

}


           




/*

       // Serialization
        var personToSerialize = new Person { Navn = "Ola Nordmann", Alder = 30 };
        string serializedJson = JsonSerializer.Serialize(personToSerialize);
        Console.WriteLine(serializedJson);


        // Deserialization
        string jsonToDeserialize = @"{""Navn"":""Kari Nordmann"",""Alder"":28}";
        Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonToDeserialize);
        Console.WriteLine($"Navn: {deserializedPerson.Navn}, Alder: {deserializedPerson.Alder}");


        // Skrive til en fil og overskrive eksisterende innhold
        string outputPath = @"C:\Users\busra\Downloads\text.txt"; 
        using (StreamWriter writer = new StreamWriter(outputPath, false))
        {
            writer.WriteLine("Dette er en test.");
        }



        // Lese fra en fil
        try
        {
            string[] lines = File.ReadAllLines(outputPath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Filen ble ikke funnet.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Tilgang nektet. Har ikke tilgangsrettigheter.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"En uventet feil oppstod: {ex.Message}");
        }


        // Skrive en ekstra linje til en eksisterende fil
        using (StreamWriter writer = new StreamWriter(outputPath, true))
        {
            writer.WriteLine("Dette er en ekstra linje.");
        }


        // Lese fra en fil med StreamReader
        try
        {
            using (StreamReader reader = new StreamReader(outputPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"En feil oppstod ved lesing av filen: {ex.Message}");
        }


        */
    

    }

static void RegisterMember()
{
    Console.WriteLine("Tast inn navn: ");
    string name = Console.ReadLine();

    Console.WriteLine("Tast inn e-post adresse: ");
    string email = Console.ReadLine();

    string newMember = $"{name}, {email} \n";
    File.AppendAllText("members.txt", newMember);

    Console.WriteLine("Medlem regisrering vellykket!");
}

static void SearchForMember()
{
    Console.WriteLine("Søk med Navn eller E-post.....");
    string query = Console.ReadLine().ToLower();

    string[] lines = File.ReadAllLines("members.txt");
    var foundMembers = lines.Where(line => line.ToLower().Contains(query)).ToList();

    if (foundMembers.Count > 0)
    {
        int count = 0;
        Console.WriteLine("Funnet medlemmer");
        foreach (string member in foundMembers)
        {
            count++;
            Console.WriteLine(member);
        }
        Console.WriteLine($"Fant {count} medlemmer med søkestreng {query}");
    }
    else
    {
        Console.WriteLine("Ingen medlem funnet!");
    }
}


}
=======
class Program{

    public delegate int Operation(int x, int y);
    public static Operation add = (x, y) => x+y;

    static void Main(string[] args)
    
    {


        //Fra PErson klassen
        Person person1 =  new Person();
        Person person2 =  new Person();

        Console.WriteLine($"Person.Count: {Person.Count}");    //2
        Console.WriteLine($"person1.Age: {person1.Age}");      //0
        Console.WriteLine($"person2.Age: {person2.Age}");      //0




        //Fra MathHelper klassen
        Console.Write("Skriv inn radiusen til sirkelen: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Kaller den statiske metoden direkte uten å instansiere MathHelper
        double area = MathHelper.CalculateCircleArea(radius);

        Console.WriteLine($"Arealet av sirkelen er: {area}");
        Console.ReadKey();  //it helps to wait unti the user clicks on any button





// without create an object we can call the Pi value with Class name.
double piValue = Calculator.Pi;
Console.WriteLine(piValue);

//to call the method
   Console.WriteLine(Sum(8,15));


    //LAMBDA UTTRYKK OG DELEGATES:

    Func<int, int> square = x => x*x;
    Console.WriteLine(square(5)); 

    // Func<int, int> square   --->Delegate part som tar en integer og returnerer en integer
    // Lambda-uttrykk x => x*x definerer en funksjon som tar en integer x og returnerer dens kvadrat 


    // add delegate'ini kullanarak toplama işlemi
    Console.WriteLine(add(5,3));


    //Func<> og Action<> Grensesnitt
    Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
    greet("World"); //output:  Hello, World!


    //Generik konusu : 
        Console.WriteLine("--------------Generic-----------------------------------------");
        var productRepository = new GenericRepository<Product>();
        var newProduct =  productRepository.CreateNew();
        productRepository.Add(newProduct);
        Console.WriteLine(productRepository);

        Console.WriteLine("--------------Generic-----------------------------------------");





        // ComplexNumber sinifinin Kullanım örneği
        var num1 = new ComplexNumber(1, 2);
        var num2 = new ComplexNumber(3, 4);

        var sum = num1 + num2; // Yeni bir ComplexNumber nesnesi oluşturur: Real=4, Imaginary=6

        Console.WriteLine($"Sum: Real={sum.Real}, Imaginary={sum.Imaginary}");


        //-----------------------------------------------------------------------------------


        //Button sinifinin kullanim ornegi
        // Button sınıfının bir nesnesini oluştur
        Button myButton = new Button();

        // Clicked olayına bir event handler metodu atayın
        // Bu örnekte, anonim bir metod kullanılacaktır
        myButton.Clicked += (sender, e) =>
        {
            Console.WriteLine("Butona basıldı!");
        };

        // Butona "tıklama" işlemini simüle edin
        Console.WriteLine("Butona tıklanacak...");
        myButton.Click(); // Bu, yukarıda atanmış olan handler'ı tetikler


//-----------------------------------------------------------------------------------

        //Point sinifinin kullanim ornegi
       // İki Point nesnesi oluştur
        Point point1 = new Point { X = 5, Y = 10 };
        Point point2 = new Point { X = 2, Y = 3 };

        // + operatörü ile iki Point nesnesini topla
        Point total = point1 + point2;

        // Toplam Point nesnesinin X ve Y değerlerini yazdır
        Console.WriteLine($"Toplamın X Koordinatı: {total.X}, Y Koordinatı: {total.Y}");



//-----------------------------------------------------------------------------------

//Fraction sinifinin kullanimi:
        // İki kesir nesnesi oluştur
        var frac1 = new Fraction(1, 2); // 1/2
        var frac2 = new Fraction(3, 4); // 3/4

        // Kesirleri topla
        var summen = frac1 + frac2;

        // Toplamı yazdır
        Console.WriteLine($"Sum of fractions: {summen}");



//-----------------------------------------------------------------------------------

//Counter ve CounterListener siniflarinin kullanimi:
var counter = new Counter();
var listener = new CounterListener();
listener.StartListening(counter);

for(int i=0; i<10; i++)
{
    counter.Increment();
}




    }

    //methoder

    public static int Sum(int a, int b){
        return a+b;
    }

    }




public class Calculator
{
    public static double Pi = 3.14159;
}



>>>>>>> 610ce3c268940d4a0db1d31a75bb696069c0f021
