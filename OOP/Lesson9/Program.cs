
//Oppgave1- Action<string> delegat med lambda uttrykk som skal skrive "Hei  'string' " ut i konsollen


Action<string> greet = name => Console.WriteLine("Hei " + name);
string name = "Ole";
greet("Backend");



Console.WriteLine("------------Oppgave 2 - Løsning 1---------------------------------------------------------------------------");


// Oppgave2 Func, Gitt en liste med strenger, bruk en Func<string, bool> for å identifisere og returnere en ny
// liste som kun inneholder strengene som er lengre enn 5 tegn.

List<string> strings = new List<string> { "Hello", "World", "Example", "Cat", "Bird" };


Predicate<string> isLong = ord => ord.Length > 5;


List<string> longWords = strings.FindAll(isLong);

foreach (string word in longWords)
{
    Console.WriteLine(word);
}

Console.WriteLine("------------Oppgave 2 - Løsning 2---------------------------------------------------------------------------");

Func<string, bool> longerThanFive = s => s.Length > 5;
List<string> longStrings = strings.Where(longerThanFive).ToList();

foreach (var str in longStrings)
{
    Console.WriteLine(str);
}

//or for print we can use this one
longStrings.ForEach(str => Console.WriteLine(str));



Console.WriteLine("------------Oppgave 3 - Løsning 1---------------------------------------------------------------------------");


// oppgave 3 Predicate Gitt en liste med desimaltall, bruk en Predicate<decimal> for å identifisere og
// fjerne alle tall som er mindre enn 10.0 fra listen
List<decimal> numbers = new List<decimal> { 5.5m, 10.5m, 10.0m, 4.0m, 12.75m, 9.8m };

numbers.RemoveAll(n => n < 10.0m);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("------------Oppgave 3 - Løsning 2---------------------------------------------------------------------------");

//or løsning-2
Predicate<decimal> lessThanTen = n => n < 10.0m;
numbers.RemoveAll(lessThanTen);

numbers.ForEach(x => Console.WriteLine(x));
//or
numbers.ForEach(Console.WriteLine);
