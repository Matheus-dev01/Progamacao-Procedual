using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        int[,] Numero = new int [TAMANHO_MATRIZ, TAMANHO_MATRIZ];
        int somatorio = 0;

        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                Numero[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        int OpcaoEscolhida = int.Parse(Console.ReadLine());
        if (OpcaoEscolhida == 1)
        {
            for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
               System.Console.WriteLine(Numero[linha, coluna]);
            }
        }
        }
        else if (OpcaoEscolhida == 2)
        {
            for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                somatorio = somatorio + Numero[linha, coluna];
            }
        }
        System.Console.WriteLine(somatorio);
        }
        else if (OpcaoEscolhida == 3)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                somatorio = somatorio + Numero[2, coluna];
            }
            System.Console.WriteLine(somatorio);
        }
        else if (OpcaoEscolhida == 4)
        {
            for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                if (linha == coluna)
                {
                    somatorio = somatorio + Numero[linha, coluna];
                }
            }
        }
        System.Console.WriteLine(somatorio);
        }
        else if (OpcaoEscolhida == 5)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                int resto = coluna % 2;
                if (resto == 0)
                {
                    somatorio = somatorio + Numero[1,coluna];
                }
            }
            System.Console.WriteLine(somatorio);
        }
    }
}
