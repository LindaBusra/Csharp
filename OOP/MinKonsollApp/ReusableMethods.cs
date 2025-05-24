using System;

class ReusableMethods


{

    public string Name = "Aila";
    private string _name = "Aila";


    public static int FindAreaOfRectangle(int a, int b)
    {
        return a * b;
    }




    public static int AddTwoTall(int x, int y)
    {
        return x + y;
    }

    public static bool IsEvenOrOdd(int x)
    {
        return x % 2 == 0;
    }

}