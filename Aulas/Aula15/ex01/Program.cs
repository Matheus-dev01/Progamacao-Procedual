using System;

struct Jogo
{
    public int id;
    public string nome;
    public double preco;
}
class Program
{
    static void Main(string[] args)
    {
        Jogo Jogo1;
        Jogo1.id = Convert.ToInt32(Console.ReadLine());
        Jogo1.nome = Console.ReadLine();
        Jogo1.preco = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine(Jogo1.id);
        System.Console.WriteLine(Jogo1.nome);
        System.Console.WriteLine(Jogo1.preco);
    }
}