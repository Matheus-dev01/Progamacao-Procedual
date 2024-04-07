using System;

class Program
{
    static void Main(string[] args)
    {
        int NumeroDigitado = Convert.ToInt32(Console.ReadLine());

        for (int contador1 = 0; contador1 < NumeroDigitado; contador1++)
        {
            for (int contador2 = 1; contador2 < NumeroDigitado; contador2++)
            {
                System.Console.Write(contador1 + " ");
                contador1 += contador2;
            }
        }
    }
}