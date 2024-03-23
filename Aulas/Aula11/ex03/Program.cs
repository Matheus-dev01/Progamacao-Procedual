using System;

class Program
{
    static void Main(string[] args)
    {
        string[] Nomes = new string[4];
        bool TemJose = false;
        
        for (int contador = 0; contador < 4; contador++)
        {
            Nomes[contador] = Console.ReadLine();
        }
        for (int contador = 0; contador < 4; contador++)
        {
        if (Nomes[contador] == "Jose")
        {
            TemJose = true;
        }
        }
        if (TemJose)
        {
            System.Console.WriteLine("Jose foi encontrado na lista");
        }
        else
        {
            System.Console.WriteLine("Jose nao foi encontrado na lista");
        }
    }
}
