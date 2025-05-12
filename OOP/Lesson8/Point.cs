//OPERATORER OG HENDELSER I KLASSER

//Operator Overloading
public class Point{

    public int X {get; set;}
    public int Y {get; set;}

    public static Point operator +(Point a, Point b){
        return new Point { X = a.X + b.X, Y = a.Y + b.Y};
    }
}