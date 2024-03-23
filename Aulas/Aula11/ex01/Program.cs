using System;
public class Program
{
    public static void Main(string[] args)
    {
       int[] idade = new int[3];
			
        for (int contador = 0; contador < 3; contador++)
        {
            idade[contador] = int.Parse(Console.ReadLine());
        }
        for (int contador = 2; contador >= 0; contador--)
        {
            Console.WriteLine(idade[contador]);
        }
    }
}