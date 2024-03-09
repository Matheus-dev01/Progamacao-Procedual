using System;

class Program
{
    static void Main (string[] agrs)
    {
        const int habitantes = 20;
        double somatoriaDosSalarios = 0;
        double maiorSalario = 0; 
        int somatoriaFilhos = 0;

        for (int contador = 1; contador <= habitantes; contador++)
        {
            System.Console.WriteLine("Digite seu salario: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }

            System.Console.WriteLine("Digite a quantidade de filhos que possui: ");
            int quantidadeFilhos = int.Parse(Console.ReadLine());

            System.Console.WriteLine("O salario da " + contador + "º pessoa eh: R$" + Math.Round(salario, 2) + " e ela possui " + quantidadeFilhos + " filho(s).");

            somatoriaDosSalarios = somatoriaDosSalarios + salario;
            somatoriaFilhos = somatoriaFilhos + quantidadeFilhos;
        }
            double mediasalarial = somatoriaDosSalarios / habitantes;
            int mediaFilhosPorHabitantes = somatoriaFilhos / habitantes;

            System.Console.WriteLine("A media salarial dos habitantes eh: R$" + Math.Round(mediasalarial, 2));
            System.Console.WriteLine("A media de filhos por habitante eh: " + mediaFilhosPorHabitantes);
            System.Console.WriteLine("O maior salario entre os habitantes eh: " + Math.Round(maiorSalario, 2));
    }
}
