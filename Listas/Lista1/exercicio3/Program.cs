using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Digite o número de moedas em centavos: ");
        int moedas = int.Parse(Console.ReadLine());

        int reais =  moedas / 100;
        int centavos = moedas % 100;

        Console.WriteLine($"O total em dinheiro eh: {reais} real(is) e {centavos} centavo(s)");
    }
}