using System;

class Program
{
    static void Main (string[] args)
    {
        int somatorio = 0;
        for (int contador = 0; contador >= 0; contador++)
        {
            int numeroDigitado = int.Parse(Console.ReadLine());
            if (numeroDigitado > 0)
            {
                somatorio = somatorio + numeroDigitado;
            }
            else
            {
                break;
            }
        }
        System.Console.WriteLine("O somatorio eh:" + somatorio);
    }
}
