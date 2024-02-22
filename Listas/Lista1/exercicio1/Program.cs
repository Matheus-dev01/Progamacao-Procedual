using System;

class Program
{
    static void Main (string[] agrs)
    {
        Console.WriteLine("Digite a primeira nota: ");
        Double nota1 = Double.Parse (Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        Double nota2 = Double.Parse (Console.ReadLine());

        Console.WriteLine("Digite a terceira nota: ");
        Double nota3 = Double.Parse (Console.ReadLine());

        Console.WriteLine("Digite a quarta nota: ");
        Double nota4 = Double.Parse (Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4.0;
        Console.WriteLine($"A média do aluno eh: {media}");
    }
}