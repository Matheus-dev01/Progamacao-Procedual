using System;

class Program
{
    static void Main (string[] args)
    {
        int AlturaRetangulo = int.Parse(Console.ReadLine());
        int BaseRetangulo = int.Parse(Console.ReadLine());

        for (int linha = 0; linha < AlturaRetangulo; linha++)
        {
            for (int coluna = 0; coluna < BaseRetangulo; coluna++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}