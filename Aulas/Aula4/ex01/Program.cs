using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Digite sua idade? ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Voce tem nacionalidade Xurupitense? ");
        bool NacionalidadeXurupitense = bool.Parse(Console.ReadLine());

        Console.WriteLine("Voce eh graduado em economia? ");
        bool economia = bool.Parse(Console.ReadLine());

        Console.WriteLine("Voce eh graduado em gestao de politicas publicas? ");
        bool gestaodePoliticasPublicas = bool.Parse(Console.ReadLine());

        bool podeconcorrer =  (idade >= 30) && (NacionalidadeXurupitense) && (economia || gestaodePoliticasPublicas);
        Console.WriteLine($"A pessoa pode concorrer a presidencia de Xurupita? {podeconcorrer}");
    }
}