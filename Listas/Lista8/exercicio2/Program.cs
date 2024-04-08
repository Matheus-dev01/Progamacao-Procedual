using System;

public struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}
class Program
{
    static void Main(string[] args)
    {
        const int QUANTIDADE_DE_PRODUTOS = 4;
        Produto[] produtos = new Produto[QUANTIDADE_DE_PRODUTOS];

        for (int contador = 0; contador < produtos.GetLength(0); contador++)
        {
         produtos[contador].id = Convert.ToInt32(Console.ReadLine());
         produtos[contador].nome = Console.ReadLine();
         produtos[contador].preco = Convert.ToDouble(Console.ReadLine());
         produtos[contador].disponivelEmEstoque = Convert.ToBoolean(Console.ReadLine());

        }
        for (int contador = 0; contador < produtos.GetLength(0); contador++)
        {
            if(produtos[contador].disponivelEmEstoque == true)
            {
                System.Console.WriteLine(produtos[contador].nome);
                System.Console.WriteLine(Math.Round(produtos[contador].preco, 2));
            }
        }
    }
}