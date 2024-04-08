using System;

class Prorgam
{
    public static void Main(string[] args)
    {
        string Palavra = Console.ReadLine();

        for (int contador = 0; contador < 3; contador++)
        {
            System.Console.Write(Palavra + "... ");
        }
    }
}