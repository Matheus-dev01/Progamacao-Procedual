using System;

class Program
{
    static void Main (string[] args)
    {
        int contadorLoop = 1;

        while (contadorLoop == 1)
        {
        System.Console.WriteLine("Digite a altura do triangulo: ");
        int AlturaTriangulo = int.Parse(Console.ReadLine());

        if (AlturaTriangulo >= 1 && AlturaTriangulo <= 9)
        {
            for (int coluna = 1; coluna <= AlturaTriangulo; coluna++) 
            {
                for (int contador = 1; contador <= coluna; contador++)
                {
                    Console.Write(contador);
                }
                System.Console.WriteLine();
            }
            contadorLoop++;
        }
        else
        {
            System.Console.WriteLine("Altura invalida, insira uma altura entre 1 e 9");
        }
        }
    }
}
