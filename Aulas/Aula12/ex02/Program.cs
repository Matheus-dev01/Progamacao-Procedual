using System;

class Program
{
    static void Main (string[] args)
    {
        int[,] Matriz = new int[8,8];

         for (int linha = 0; linha < 8; linha++)
        {
            for (int coluna = 0; coluna < 8; coluna++)
            {
                if(linha == coluna)
                {
                    Matriz[linha, coluna] = 1;
                }
                else
                {
                Matriz[linha, coluna] = 0;
                }
            }
        }
        for (int linha = 0; linha < 8; linha++)
        {
            for (int coluna = 0; coluna < 8; coluna++)
            {
                System.Console.Write(Matriz[linha,coluna]);
            }
            System.Console.WriteLine();
        }
    }
}