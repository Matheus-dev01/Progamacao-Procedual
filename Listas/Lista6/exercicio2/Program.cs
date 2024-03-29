using System;
class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_LISTA = 10;
        string[] ListadeNomes = new string[TAMANHO_LISTA];

        for (int contador = 0; contador < TAMANHO_LISTA; contador++)
        {
            ListadeNomes[contador] = Console.ReadLine();
        }
        for (int contador = 9; contador >= 0; contador--)
        {
            int resto = contador % 2;

            if (resto == 0)
            {
                System.Console.WriteLine(ListadeNomes[contador]);
            }
        }
    }
}