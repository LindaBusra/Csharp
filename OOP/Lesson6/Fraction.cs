public class Fraction
{

public int Numerator{ get; set;}
public int Denominator { get; set;}


public Fraction(int numerator, int denominator){

    Numerator = numerator;
    Denominator = denominator;
}


//Tilpasset + operator for å legge sammen to Fraction objecter
public static Fraction operator +(Fraction a, Fraction b)
{
    // Ortak payda, paydaların çarpımı olmalı
     int commonDenominator = a.Denominator * b.Denominator;

    // Paylar çapraz çarpılıp toplanmalı
     int numeratorSum = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
    return new Fraction (numeratorSum, commonDenominator);
}


//En ToString metode for enkel visning av brøken
public override string ToString()
{
    return $"{Numerator}/{Denominator}";
}





}