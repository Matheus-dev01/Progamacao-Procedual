using System;

class Program
{
    static void Main (string[] args)
    {
        for (int numerador = 10; numerador >= 1; numerador--)
        {
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                int resultadoMultiplicacao = numerador * multiplicador;
                System.Console.WriteLine(numerador + " x " + multiplicador + " = " + resultadoMultiplicacao);
            }
            System.Console.WriteLine("\n");        
        }
    }
}