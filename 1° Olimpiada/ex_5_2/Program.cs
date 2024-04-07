using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contador = 0; contador >= 0; contador++)
        {
            int NumeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (NumeroDigitado > 1 && NumeroDigitado % 2 != 0)
            {
                for (int linha = 0; linha <= NumeroDigitado; linha++)
                {
                    for (int coluna = 0; coluna < NumeroDigitado; coluna++)
                    {
                        if (linha == 0 || linha == NumeroDigitado)
                        {
                            System.Console.Write("-");
                        }
                    }
                    System.Console.Write("\\    /");
                    System.Console.Write("/ \\");
                    System.Console.WriteLine("");
                }
                break;
            }
            System.Console.WriteLine("Erro! Digite um número ímpar e maior que 1");
        }
    }
}