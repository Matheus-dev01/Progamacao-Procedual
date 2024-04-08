using System;

struct Enxadrista
{
    public int id;
    public string nome;
    public int rating;
}
class Program
{
    static void Main(string[] args)
    {
        const int QUANTIDADE_ENXADRISTA = 4;
        Enxadrista[] Enxadristas = new Enxadrista[QUANTIDADE_ENXADRISTA];

        for (int contador = 0; contador < QUANTIDADE_ENXADRISTA; contador++)
        {
            Enxadristas[contador].id = Convert.ToInt32(Console.ReadLine());
            Enxadristas[contador].nome = Console.ReadLine(); 
            Enxadristas[contador].rating = Convert.ToInt32(Console.ReadLine());
        }
        for (int contador = 3; contador >= 0; contador--)
        {
            System.Console.WriteLine(Enxadristas[contador].id);
            System.Console.WriteLine(Enxadristas[contador].nome);
            System.Console.WriteLine(Enxadristas[contador].rating);
        }
    }
}