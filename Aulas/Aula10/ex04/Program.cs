using System;

class Program
{
    static void Main (string[] args)
    {
        for (int linha = 9; linha >= 1; linha--)
        {
            for (int coluna = 9; coluna >= linha; coluna--)
            {
                System.Console.Write(coluna);
            }
            System.Console.WriteLine();
        }
    }
}