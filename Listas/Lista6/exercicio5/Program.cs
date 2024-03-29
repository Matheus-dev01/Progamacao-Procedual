using System;
class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 10;
        int[] Numeros = new int[TAMANHO_VETOR];
        int contador = 0;

        while (contador < TAMANHO_VETOR)
        {
            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado >= 10 && numeroDigitado <= 50)
            {
                Numeros[contador] = numeroDigitado;
                contador++;
            }
        }
        for (contador = 0; contador < TAMANHO_VETOR; contador++)
        {
          Console.WriteLine(Numeros[contador]);
        }
    }
}