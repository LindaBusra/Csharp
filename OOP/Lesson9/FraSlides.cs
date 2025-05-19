/*
// Definere og bruke delegater
// Oppgave 1: Lag en delegat som tar imot to heltall (int) og returnerer en heltall(int)
public delegate int MathOperation(int a, int b);

public class Program
{
    public static void Main(string[] args)
    {
        MathOperation add = (a, b) => a + b;
        MathOperation subtract = (a, b) => a - b;
        MathOperation multiply = (a, b) => a * b;

        Console.WriteLine($"Add: {PerformOperation(add, 5, 3)}");
        Console.WriteLine($"Subtract: {PerformOperation(subtract, 5, 3)}");
        Console.WriteLine($"Multiply: {PerformOperation(multiply, 5, 3)}");
    }

    static int PerformOperation(MathOperation operation, int a, int b)
    {
        return operation(a, b);
    }
}

*/


/*
// Oppgave 1: Lag en klasse button som har et event "Clicked". Lag en methode ButtonClicked
// som abonnerer på dette eventet og skriver ut en melding til konsollen når knappen klikkes
//(Simuler)
public delegate int MathOperation(int a, int b);

public class Program
{
public static void Main(string[] args)
{
    var button = new Button();
    button.Clicked += OnButtonClicked;
    button.Click();
}

static void OnButtonClicked(object sender, EventArgs e)
{
    Console.WriteLine("Button was Clicked!");
}
}

*/


/*
//Oppgave 3-Annonyme metoder og lambda uttrykk

List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9};

//Definerer et Predicate<int> for å filtrere ut oddetall
Predicate<int> isOdd = num => num%2 !=0;

//Definer en Action<int> for å skrive ut tallene i konsole
Action<int> print = num => Console.WriteLine(num);

//Bruke predicate for å filtrere ut oddetall fra listen
List<int> oddNumbers = numbers.FindAll(isOdd);


oddNumbers.ForEach(print);
*/










/* Fra undervisning-Slider

//Func delegates
Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(7, 8));

//Action Delegates:
Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
greet("Alice");

//Avanserte delegater

Action<string> logger = Console.WriteLine;
logger += message => File.AppendText("log.txt").WriteLine(message);
logger("Application started");      




//Predicate delegates
Predicate<int> isEven = number => number % 2 == 0;
Console.WriteLine(isEven(4)); // Output: True
Console.WriteLine(isEven(5)); // Output: False

//LAmbda-Uttrykk
var numbers = new List<int> { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

foreach (var n in evenNumbers)
{
    Console.WriteLine(n);
}


/*
//Event og eventhandler <T>

public event EventHandler<MyEventArgs> MyEvent;

protected virtual void OnMyEvent(MyEventArgs e)
{
    MyEvent?.Invoke(this, e);
}
*/