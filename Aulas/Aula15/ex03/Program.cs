using System;

struct Heroi
{
    public int id;
    public string nome;
    public int level;
}
class Program
{
    static void GroupLevelUp(Heroi[] herois)
    {
        for (int contador = 0; contador < 3; contador++)
        {
            herois[contador].level += 1;
        }
        for (int contador = 0; contador < 3; contador++)
        {
            System.Console.WriteLine(herois[contador].id);
            System.Console.WriteLine(herois[contador].nome);
            System.Console.WriteLine(herois[contador].level);
        }
    }
    static void Main(string[] args)
    {
        const int QUANTIDADE_HEROI = 3;
        Heroi[] herois = new Heroi[QUANTIDADE_HEROI];

        for (int contador = 0; contador < QUANTIDADE_HEROI; contador++)
        {
            herois[contador].id = Convert.ToInt32(Console.ReadLine());
            herois[contador].nome = Console.ReadLine(); 
            herois[contador].level = Convert.ToInt32(Console.ReadLine());
        }
        GroupLevelUp(herois);
    }
}