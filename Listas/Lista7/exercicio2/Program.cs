using System;

class Program
{
    static int MaiorNumero(int numero1, int numero2, int numero3)
    {
        int EhOMaior = 0;

        if (numero1 > numero2 && numero1 > numero3)
        {
            return EhOMaior = numero1;
        }
        else if (numero2 > numero1 && numero2 > numero3)
        {
            return EhOMaior = numero2;
        }
        else if (numero3> numero1 && numero3 > numero2)
        {
            return EhOMaior = numero3;
        }
        else
        {
           if (numero1 == numero2)
           {
                return EhOMaior = numero1;
           }
           else if (numero2 == numero3)
           {
                return EhOMaior = numero2;
           }
           else
           {
                return EhOMaior = numero3;
           }
        }
        
    }
    static void Main(string[] args)
    {
        int numero1 = Convert.ToInt32(Console.ReadLine());
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int numero3 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine(MaiorNumero(numero1, numero2, numero3));
    }
}