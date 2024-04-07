using System;

class Prorgam
{
    static void PreencherMatriz(bool[,] VagasEstacionamneto)
    {
        for (int linha = 0; linha < VagasEstacionamneto.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < VagasEstacionamneto.GetLength(1); coluna++)
            {
                VagasEstacionamneto[linha, coluna] = Convert.ToBoolean(Console.ReadLine());
            }
        }
    }
    static int VagasLivres(bool[,] VagasEstacionamneto) 
    {
        int VagasLivres = 0;
        for (int linha = 0; linha < VagasEstacionamneto.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < VagasEstacionamneto.GetLength(1); coluna++)
            {
                if (VagasEstacionamneto[linha, coluna] == false)
                {
                   VagasLivres += 1;
                }
                
            }
        }
        return VagasLivres;
    }
    static void Main(String[] args)
    {
        const int TAMANHO_MATRIZ = 3;
        bool[,] VagasEstacionamento = new bool[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        PreencherMatriz(VagasEstacionamento); 
        
        System.Console.WriteLine("Existem " + VagasLivres(VagasEstacionamento) + " vagas livres");
    }
}