using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha um dos paises para visitar:\n[1] - Pais do vento\n[2] - Pais do fogo ");
        int paisescolhido = int.Parse(Console.ReadLine());

        for (var soma = 1; soma < 10; soma++)
        {
            if (soma < 10)
            {
                if (paisescolhido == 1)
                {
                    Console.WriteLine("Voce escolheu o Pais do vento!");
                    Console.WriteLine("Escolha um ponto de exploração para visitar:\n[1] - Aldeia da areia\n[2] - Mina\n[3] - Caatinga");

                    int pontoDeExploração = int.Parse(Console.ReadLine());

                    if (pontoDeExploração == 1)
                    {
                        Console.WriteLine("Bem-Vindo a aldeia da areia! ");
                    }
                    else if (pontoDeExploração == 2)
                    {
                        Console.WriteLine("Aqui fica a mina!");
                    }
                    else
                    {
                        Console.WriteLine("Você adentrou a caatinga!");
                    }
                }

                if (paisescolhido == 2)
                {
                    Console.WriteLine("Voce escolheu o Pais do fogo!");
                    Console.WriteLine("Escolha um ponto de exploração para visitar:\n[1] - Aldeia do fogo\n[2] - Vulcão\n[3] - Nordeste");

                    int pontoDeExploração = int.Parse(Console.ReadLine());

                    if (pontoDeExploração == 1)
                    {
                        Console.WriteLine("Bem-Vindo a aldeia do fogo! ");
                    }
                    else if (pontoDeExploração == 2)
                    {
                        Console.WriteLine("Aqui fica ao vulcão!");
                    }
                    else
                    {
                        Console.WriteLine("Você adentrou ao nordeste!");
                    }
                }

                Console.WriteLine("Deseja visitar outros lugares? sim ou nao? ");
                string fazerOutraVisita = Console.ReadLine();

                if (fazerOutraVisita == "sim")
                {
                    Console.WriteLine("Vamos viajar!");
                }
                else
                {
                    Console.WriteLine("Obrigado por viajar com a MR viajens! ");
                    soma = 10 + 10;
                }
            }
            else
            {
                Console.WriteLine("Obrigado por viajar com a MR viajens! ");
               soma = 10 + 10;
            }
        }
    }
}