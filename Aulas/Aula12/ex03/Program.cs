using System;

class Program
{
    static void Main (string[] args)
    {
        int[,] Matriz = new int[4,4];
        int somatorio = 0;

         for (int linha = 0; linha < 4; linha++)
        {
            for (int coluna = 0; coluna < 4; coluna++)
            {
                Matriz[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
         for (int linha = 0; linha < 4; linha++)
        {
            for (int coluna = 0; coluna < 4; coluna++)
            {
                somatorio = Matriz[linha, coluna] + somatorio;
            }
        }
        System.Console.WriteLine("A soma de todos os elementos da matriz eh: " + somatorio);
    }
}