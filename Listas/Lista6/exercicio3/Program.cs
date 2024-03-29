using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;
        int[,] Numeros = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];
        int somatorio = 0;

        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                Numeros[linha, coluna] = int.Parse(Console.ReadLine());
                if(linha == coluna)
                {
                    somatorio = somatorio + Numeros[linha, coluna];
                }
            }
        }
        System.Console.WriteLine(somatorio);
    }
}