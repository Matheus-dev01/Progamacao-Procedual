using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;
        int[,] Numeros = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                Numeros[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        Numeros[0,2] = Numeros[0,2] * 2;
        Numeros[1,1] = Numeros[1,1] * 2;
        Numeros[2,0] = Numeros[2,0] * 2;

        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                Console.Write(Numeros[linha, coluna] + "|");
            }
            System.Console.WriteLine();
        }

    }
}