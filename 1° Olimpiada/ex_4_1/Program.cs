using System;

class Prorgam
{
    static double ConversaoFahrenheit(double TemperaturaEmCelscius)
    {
        double TemperaturaEmFahrenheit = ((9.0/5.0) * TemperaturaEmCelscius) + 32; 
        return TemperaturaEmFahrenheit;
    }
    static void Main(String[] args)
    {
        double TemperaturaEmCelscius = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(ConversaoFahrenheit(TemperaturaEmCelscius));
    }
}