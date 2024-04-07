using System;

class Program
{
    static void Main(string[] args)
    {
        int DiasVividos = Convert.ToInt32(Console.ReadLine());

        int Anos = DiasVividos / 365;
        int Dias = DiasVividos % 365;

        Console.WriteLine("Essa pessoa viveu " + Anos + " ano(s)");
    }
}