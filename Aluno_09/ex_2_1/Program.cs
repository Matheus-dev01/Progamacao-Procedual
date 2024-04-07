using System;

class Program
{
    static void Main(string[] args)
    {
        int PratasPorKM = 25;
        double QuilometragemExpedicao = Convert.ToDouble(Console.ReadLine());

        double PrecoFinal = QuilometragemExpedicao * PratasPorKM;
        System.Console.WriteLine("O preco final de sua expedicao eh: " + Math.Round(PrecoFinal, 2) + " pratas");
    }
}