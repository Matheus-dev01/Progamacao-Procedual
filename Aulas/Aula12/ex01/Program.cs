using System;

class Program
{
    static void Main(string[] args)
    {
        char[,] Matriz = new char[3,3];

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Matriz[linha, coluna] = char.Parse(Console.ReadLine());
            }
        }
        for (int linha = 2; linha >= 0; linha--)
        {
            for (int coluna = 2; coluna >= 0; coluna--)
            {
                System.Console.WriteLine(Matriz[linha,coluna]);
            }
            System.Console.WriteLine();
        }
    }
}