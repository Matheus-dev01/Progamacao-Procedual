using System;

class Prorgam
{
    static void Main(String[] args)
    {
        int TamanhoDaPiramide = Convert.ToInt32(Console.ReadLine());

        for (int linha = 0; linha <= TamanhoDaPiramide; linha++)
        {
            for (int coluna = 0; coluna <= linha; coluna++)
            {
                for (int contador = 0; contador < coluna; contador++)
                {
                    System.Console.Write("*");
                }
            }
            System.Console.WriteLine("");
        }

    }
}