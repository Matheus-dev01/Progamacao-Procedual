using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        System.Console.WriteLine("Digite sua alcunha: ");
        string alcunha = Console.ReadLine();

        System.Console.WriteLine($"{nome}, mais conhecido como: {alcunha}");
    }
}