using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contador = 120; contador >= 0; contador--)
        {
            int minutos = contador / 60;
            int segundos = contador % 60;

            System.Console.WriteLine($"{minutos}:{segundos}");
        }
    }
}