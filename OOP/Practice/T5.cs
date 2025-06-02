
Console.WriteLine("-----------------Inner - Outer ---------------------------");

for (int i = 1; i <= 2; ++i) 
{
  Console.WriteLine("Outer: " + i);  

  // Inner loop
  for (int j = 1; j <= 3; j++) 
  {
    Console.WriteLine(" Inner: " + j); 
  }
}


Console.WriteLine("-----------------Break Example---------------------------");

int k = 0;
while (k < 10) 
{
  Console.WriteLine(k);
  k++;
  if (k == 4) 
  {
    break;
  }
}



Console.WriteLine("-----------------Continue Example---------------------------");

int n = 0;
while (n < 10) 
{
  if (n == 4) 
  {
    n++;
    continue;
  }
  Console.WriteLine(n);
  n++;
}