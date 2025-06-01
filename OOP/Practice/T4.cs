/*

// Create an array of four elements, and add values later
string[] cars1 = new string[4];

// Create an array of four elements and add values right away 
string[] cars2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements without specifying the size 
string[] cars3 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars4 = {"Volvo", "BMW", "Ford", "Mazda"};



Console.WriteLine("----------------Array------------------");
string[] cars = {"Volvo", "BMW", "Ford", "Mazda" };

//Print the value of the second element in the cars array.
Console.WriteLine(cars[1]);

//Change the value from "Volvo" to "Opel", in the cars array.
cars[0]="Opel";
Console.WriteLine(cars[0]);

//Loop through the elements in the cars array using the foreach loop.
foreach(string i in cars) {
    Console.WriteLine(i);
}


//Use the correct method to sort the cars array.
Array.Sort(cars);
Console.WriteLine("After sort: ");
foreach(string i in cars) {
    Console.WriteLine(i);
}


Console.WriteLine("----------------Methods------------------");
myMethod();
greeting("Ole");


static void myMethod(){
   Console.WriteLine("I just got executed!");
}

static void greeting(string fname){
   Console.WriteLine("Hello " + fname);
}



Console.WriteLine("----------------Try - catch ------------------");
try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch
 (Exception e)
{
  Console.WriteLine(e.Message);
}




try

{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch
 (Exception e)
{
  Console.WriteLine("Something went wrong.");
}
finally

{
  Console.WriteLine("The 'try catch' is finished.");
}


*/