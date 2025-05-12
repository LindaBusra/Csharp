<<<<<<< HEAD
public class Person{

    public string Navn {get; set;}
    public int Alder {get; set; }
}


=======
public class Person
{

    public static int Count { get; private set; } = 0; //statisk property

    public int Age { get; set;}  //ikke statisk property


    public Person(){

        Count++;
    }
}
>>>>>>> 610ce3c268940d4a0db1d31a75bb696069c0f021
