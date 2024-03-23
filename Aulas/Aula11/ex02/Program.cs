using System;
class Program
{
    static void Main(string[] args)
    {
        int[] NumerosPares = new int[5];
        int contador = 0;

        while (contador < 5)
        {
        int NumerosDigitados = int.Parse(Console.ReadLine());

        if (NumerosDigitados % 2 == 0)
        {
            NumerosPares[contador] = NumerosDigitados;
            contador++;
        }
        } 
        for (contador = 0; contador < 5; contador++)
        {
            System.Console.WriteLine(NumerosPares[contador]);
        }
    }
}
