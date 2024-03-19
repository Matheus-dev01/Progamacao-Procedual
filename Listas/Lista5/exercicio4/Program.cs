using System;

class Program
{
    static void Main(string[] args)
    {
        int somatorio = 0;
        int NumeroDigitado = 0;
        do
        {
            NumeroDigitado = int.Parse(Console.ReadLine());
            int sobra = NumeroDigitado % 2;

            if (sobra != 0)
            {
                if (NumeroDigitado >= 0)
                {
                    somatorio = somatorio + NumeroDigitado;
                }
            }
        } while (NumeroDigitado >= 0);
        System.Console.WriteLine("O somatorio de impares eh: " + somatorio);
    }
}