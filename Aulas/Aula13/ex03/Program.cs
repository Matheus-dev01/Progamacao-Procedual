using System;
class Program
{
    static void viajar()
    {
        int PaisEscolhido = Convert.ToInt32(Console.ReadLine());

        if (PaisEscolhido == 1)
        {
            VisitarPaisDoFogo();
        }
        else if (PaisEscolhido == 2)
        {
            VisitarPaisDoVento();
        }
    }
    static void VisitarPaisDoFogo()
    {
        int LocalEscolhido = Convert.ToInt32(Console.ReadLine());

        if (LocalEscolhido == 1)
        {
            System.Console.WriteLine("Voce adentrou: Aldeia da Folha");
        }
        else if (LocalEscolhido == 2)
        {
            System.Console.WriteLine("Voce adentrou: Floresta da Morte");
        }
    }
    static void VisitarPaisDoVento()
    {
        int LocalEscolhido = Convert.ToInt32(Console.ReadLine());

        if (LocalEscolhido == 1)
        {
            System.Console.WriteLine("Voce adentrou: Aldeia da areia");
        }
        else if (LocalEscolhido == 2)
        {
            System.Console.WriteLine("Voce adentrou: Mina");
        }
        else if (LocalEscolhido == 3)
        {
            System.Console.WriteLine("Voce adentrou: Caatinga");
        }
    }
    static void Main(string[] args)
    {
        viajar();
    }
}