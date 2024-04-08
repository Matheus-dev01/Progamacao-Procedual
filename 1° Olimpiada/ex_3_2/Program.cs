using System;

class Program
{
    static void Main(string[] args)
    {
        int HorasTrablhadasNaSemana = Convert.ToInt32(Console.ReadLine());
        double SalarioSemanal = 600.0;

        if (HorasTrablhadasNaSemana > 40)
        {
           int HorasExtra = HorasTrablhadasNaSemana - 40;
           double ValorHoraExtra = HorasExtra * 25;
           SalarioSemanal = SalarioSemanal + ValorHoraExtra;
        }
        System.Console.WriteLine(Math.Round(SalarioSemanal, 2));
    }
}