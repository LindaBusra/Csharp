public class Person
{

    public static int Count { get; private set; } = 0; //statisk property

    public int Age { get; set;}  //ikke statisk property


    public Person(){

        Count++;
    }
}