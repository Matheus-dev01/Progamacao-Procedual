using System;

class Program
{
    static void Main(string[] args)
    {
        string[] Nomes = new string[5];
        int[] Idades = new int[5];
        bool[] ehCasado = new bool[5];

        for (int contador = 0; contador < 5; contador++)
        {
            Nomes[contador] = Console.ReadLine();
            Idades[contador] = int.Parse(Console.ReadLine());
            ehCasado[contador] = bool.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("As pessoas casadas sao:");
        for (int contador = 0; contador < 5; contador++)
        {
            if (ehCasado[contador] == true)
            {
                System.Console.WriteLine($"{Nomes[contador]}, de {Idades[contador]} anos");
            }
        }
    }
}