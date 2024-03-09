using System; 

class Program 
{
    static void Main (string[] agrs)
    {
        int quantidadeTotalItens = 1;
        double somaDosValores = 0; 
        System.Console.WriteLine("Digite a quantidade de itens comprados: ");
        int quantidadeItensComprados = int.Parse(Console.ReadLine());

        while (quantidadeTotalItens <= quantidadeItensComprados)
        {
            System.Console.WriteLine("Digite o valor do " + quantidadeTotalItens + "º item:");
            double valorDoItem = double.Parse(Console.ReadLine());

            somaDosValores = somaDosValores + valorDoItem;
            quantidadeTotalItens++;
        }

        if (somaDosValores >= 150)
        {
            System.Console.WriteLine("Parabens! Voce ganhou frete gratis em sua compra no valor de R$" + somaDosValores);
        }
        else
        {
            System.Console.WriteLine("A compra nao possui frete gratis");
        }
    }
}