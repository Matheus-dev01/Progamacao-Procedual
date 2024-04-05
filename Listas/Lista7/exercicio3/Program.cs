using System;

class Program
{
    static string ClassificarNadador(int idade)
    {
           if (idade < 12)
           {
                return "Infantil";
           }
           else if (idade >= 12 && idade <= 14)
           {
                return "Juvenil A";
           }
           else if (idade >= 15 && idade <= 17)
           {
                return "Juvenil B";
           }
           else
           {
                return "Adulto";
           }
    }
    static void Main(string[] args)
    {
        int idade = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine(ClassificarNadador(idade));
    }
}
