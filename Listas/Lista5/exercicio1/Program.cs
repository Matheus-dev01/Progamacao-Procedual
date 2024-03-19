using System;

class Program
{
    static void Main (string[] args)
    {
        int ContagemCrescente = 0;
        int ContagemDecrescente = 200;
        while (ContagemCrescente <= 100 && ContagemDecrescente >= 0)
        {
            System.Console.WriteLine(ContagemCrescente + " - " + ContagemDecrescente);
            ContagemCrescente = ContagemCrescente + 2;
            ContagemDecrescente = ContagemDecrescente - 4;
        }
    }
}