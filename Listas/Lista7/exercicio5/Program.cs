using System;

class Program
{
    static void PreencherMatriz(int[,] Matriz)
    {
        for (int linha = 0; linha < Matriz.GetLength(0); linha++)
        {
          for (int coluna = 0; coluna < Matriz.GetLength(0); coluna++)
          {
            Matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
          }   
        }
    }
    static bool TemZero(int[,] Matriz)
    {
        for (int linha = 0; linha < Matriz.GetLength(0); linha++)
        {
          for (int coluna = 0; coluna < Matriz.GetLength(0); coluna++)
          {
            if (Matriz[linha, coluna] == 0)
            {
                return true;
            }
          }   
        }
        return false;
    }
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        int[,] Matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        PreencherMatriz(Matriz);

        if (TemZero(Matriz) == true)
        {
            System.Console.WriteLine("Fique atento! existem balistas no tabuleiro");
        }
        else
        {
            System.Console.WriteLine("nao ha balistas no tabuleiro");
        }
    }
}
