using System;

class Program
{
    static void Main (string [] args)
    {
        for (int contador = 1; contador <= 10; contador++)
        {
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                int resultado = contador * multiplicador;
                System.Console.WriteLine($"{contador} X {multiplicador} = {resultado}");
            }
            System.Console.WriteLine("\n");
        }
    }
}