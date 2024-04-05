using System;

class Program
{
    static bool EhPar(int numero)
    {
        if (numero % 2 == 0)
        {
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        int numero = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(EhPar(numero));
    }
}
