using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Digite a base do Triângulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do Triângulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());
        
        double area = (baseTriangulo*alturaTriangulo)/2;

        bool maior = area > 20;

        Console.WriteLine($"A área do triângulo é maior que 20? {maior}");
    }
}