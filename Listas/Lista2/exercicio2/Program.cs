using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota: ");
        double nota4 = double.Parse(Console.ReadLine());

        double notaFinal = ((nota1 + nota2 + nota3 + nota4) / 4);
        
        if (notaFinal >= 5)
        {
            Console.WriteLine("Aluno aprovado");
        }
        else if (notaFinal < 5 && notaFinal >= 3)
        {
            Console.WriteLine("Aluno em recuperacao");
        }
        else 
        {
            Console.WriteLine("Aluno reprovado");
        }
    }
}