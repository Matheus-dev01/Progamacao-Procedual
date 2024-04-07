using System;

class Program
{
    static void EhOMenor(int numero1, int numero2, int numero3)
    {
        if (numero1 < numero2 && numero1 < numero3)
        {
            System.Console.WriteLine(numero1);
        }
        else if (numero2 < numero1 && numero2 < numero1)
        {
            System.Console.WriteLine(numero2);
        }
        else if (numero3 < numero1 && numero3 < numero2)
        {
            System.Console.WriteLine(numero3);
        }
        else 
        {
            System.Console.WriteLine("Não foi possivel calcular o maior");
        }
    }
    static void Main(string[] args)
    {
        int numero1 = int.Parse(Console.ReadLine());
        int numero2 = int.Parse(Console.ReadLine());
        int numero3 = int.Parse(Console.ReadLine());

        EhOMenor(numero1, numero2, numero3);
    }
}