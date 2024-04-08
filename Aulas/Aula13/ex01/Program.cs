using System;

class Program
{
    static bool MaiorIdade(int idade)
    {
        if (idade >= 18)
        {
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        int idade = int.Parse(Console.ReadLine());
    
        bool ehMaior = MaiorIdade(idade);

        System.Console.WriteLine(ehMaior);
    }
}
