using System;
class Program
{
    static double CalcularHipotenusa(double cateto1, double cateto2)
    {
       return Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
    }
    static void Main(string[] args)
    {
        double cateto1 = Convert.ToDouble(Console.ReadLine());
        double cateto2 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine(CalcularHipotenusa(cateto1, cateto2));
    }
}