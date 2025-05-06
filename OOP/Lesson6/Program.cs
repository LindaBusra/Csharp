using System;
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



