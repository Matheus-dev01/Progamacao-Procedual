using System;

public struct EquipeDeXadrez
{
    public string NomeJogadores;
    public int Rating;
}
class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_EQUIPE = 5;
        EquipeDeXadrez[] Jogadores = new EquipeDeXadrez[TAMANHO_EQUIPE];

        double MediaRating = 0;
        int MaiorRating = 0;
        int MenorRating = 10000;
        string JogadorDoPrimeiroTabuleiro = "";

        for (int contador = 0; contador < TAMANHO_EQUIPE; contador++)
        {
            Jogadores[contador].NomeJogadores = Console.ReadLine();
            Jogadores[contador].Rating = Convert.ToInt32(Console.ReadLine());

            MediaRating += Jogadores[contador].Rating;

            if (Jogadores[contador].Rating > MaiorRating)
            {
                JogadorDoPrimeiroTabuleiro = Jogadores[contador].NomeJogadores;
            }

            if (Jogadores[contador].Rating < MenorRating)
            {
                MenorRating = Jogadores[contador].Rating;
            }
        }
        MediaRating = MediaRating / TAMANHO_EQUIPE;
        System.Console.WriteLine($"Media de rating: {MediaRating} \nPrimeiro tabuleiro: {JogadorDoPrimeiroTabuleiro} \nMenor rating: {MenorRating}");
    }
}