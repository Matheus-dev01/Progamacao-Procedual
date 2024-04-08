using System;

public struct Pizza
{
    public int id;
    public string sabor;
    public double preco;
}
class Program
{
    static void Main(string[] args)
    {
        Pizza[] Pizza = new Pizza[1];

        for (int contador = 0; contador < Pizza.GetLength(0); contador++)
        {
            Pizza[contador].id = Convert.ToInt32(Console.ReadLine());
            Pizza[contador].sabor = Console.ReadLine();
            Pizza[contador].preco = Convert.ToDouble(Console.ReadLine());
        }
        for (int contador = 0; contador < Pizza.GetLength(0); contador++)
        {
            System.Console.WriteLine(Pizza[contador].id);
            System.Console.WriteLine(Pizza[contador].sabor);
            System.Console.WriteLine(Pizza[contador].preco); 
        }
    }
}