using System;

class Program
{
    static void Main(string[] args)
    {
        const int TOTAL_PESSOAS = 10;
       string[] ListadeNomes = new string[TOTAL_PESSOAS];
       bool NomeBuscado = false;

       for(int contador = 0; contador < TOTAL_PESSOAS; contador++)
       {
            ListadeNomes[contador] = Console.ReadLine();
       }
        string Nome = (Console.ReadLine());

        for(int contador = 0; contador < TOTAL_PESSOAS; contador++)
       {
            if (ListadeNomes[contador] == Nome)
            {
                NomeBuscado = true;
            }
       }
       if(NomeBuscado)
        {
            System.Console.WriteLine("ACHEI");
        }
        else
        {
           System.Console.WriteLine("NAO ACHEI");
        } 
    }
}