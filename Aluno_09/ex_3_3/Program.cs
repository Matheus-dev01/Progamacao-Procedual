using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        string[,] MatrizAcentos = new string[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        for (int linha = 0; linha < MatrizAcentos.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < MatrizAcentos.GetLength(1); coluna++)
            {
                if (linha == 0)
                {
                    MatrizAcentos[0, coluna] = "Vip";
                }
                else if (linha > 0)
                {
                    MatrizAcentos[linha, coluna] = "Associado";
                }
            }
        }
        for (int linha = 0; linha < MatrizAcentos.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < MatrizAcentos.GetLength(1); coluna++)
            {
               if (linha == coluna)
                {
                    MatrizAcentos[linha, coluna] = "Sorteado";
                }
                System.Console.Write(MatrizAcentos[linha,coluna] + " ");
            }
            System.Console.WriteLine("");
        }
    }
}