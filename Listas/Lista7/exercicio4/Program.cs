using System;
using System.Numerics;

class Program
{
    static void PesoDoVagao(int[] vetor)
    {
        for (int contador = 1; contador < vetor.GetLength(0); contador++)
        {
             vetor[contador] = Convert.ToInt32(Console.ReadLine());
        }
    }
    static void ValidarPeso(int[] vetor)
    {
        for (int contador = 1; contador < vetor.GetLength(0); contador++)
        {
            if (vetor[contador] > 50)
            {
                 System.Console.WriteLine($"{contador}° vagao ultrapassou o limite de peso");   
            }
        }
    }
    static void Main(string[] args)
    {
        const int VAGOES_DO_TREM = 13;
        int[] VetorPeso = new int[VAGOES_DO_TREM];
        
        PesoDoVagao(VetorPeso);
        ValidarPeso(VetorPeso);

    }
}
