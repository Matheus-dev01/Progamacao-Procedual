using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;
        char[,] tabuleiro = new char[TAMANHO_MATRIZ, TAMANHO_MATRIZ];
        InicializaTabuleiro(tabuleiro);

        int contador = 0;
        bool ganhou = false;

        do
        {
            ImprimeTabuleiro(tabuleiro);
            System.Console.WriteLine("Jogador 1 faça sua jogada");
            ganhou = RealizarJogada(tabuleiro, 1);
            if(ganhou)
            {
                ImprimeTabuleiro(tabuleiro);
                System.Console.WriteLine("O jogador 1 ganhou o jogo");
                break;
            }

            ImprimeTabuleiro(tabuleiro);
            System.Console.WriteLine("Jogador 2 faça sua jogada");
            ganhou = RealizarJogada(tabuleiro, 2);
            if(ganhou)
            {
                ImprimeTabuleiro(tabuleiro);
                System.Console.WriteLine("O jogador 2 ganhou o jogo");
                break;
            }
            
            ImprimeTabuleiro(tabuleiro);
            System.Console.WriteLine("Jogador 1 faça sua jogada");
            ganhou = RealizarJogada(tabuleiro, 1);
            if(ganhou)
            {
                ImprimeTabuleiro(tabuleiro);
                System.Console.WriteLine("O jogador 1 ganhou o jogo");
                break;
            }

            ImprimeTabuleiro(tabuleiro);
            System.Console.WriteLine("Jogador 2 faça sua jogada");
            ganhou = RealizarJogada(tabuleiro, 2);
            if(ganhou)
            {
                ImprimeTabuleiro(tabuleiro);
                System.Console.WriteLine("O jogador 2 ganhou o jogo");
                break;
            }
            contador++;
        }
        while(contador < TAMANHO_MATRIZ * TAMANHO_MATRIZ);

        if (contador == TAMANHO_MATRIZ * TAMANHO_MATRIZ && !ganhou)
        {
            
        }
    }

    static void InicializaTabuleiro(char[,] tabuleiro)
    {
        for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < tabuleiro.GetLength(1); coluna++)
            {
                tabuleiro[linha, coluna] = '-';
            }
        }
    }
    static void ImprimeTabuleiro(char[,] tabuleiro)
    {
        for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < tabuleiro.GetLength(1); coluna++)
            {
                Console.Write(tabuleiro[linha, coluna]);
            }
        }
    }

    static bool RealizarJogada(char[,] tabuleiro, int idJogador)
    {
        int linha = 0;
        int coluna = 0;

        do
        {
            System.Console.WriteLine("Escolha as cordenadas da sua jogada: ");
            linha = Convert.ToInt32(Console.ReadLine());
            coluna = Convert.ToInt32(Console.ReadLine());
            if ((linha >= 0 && linha < 3) && (tabuleiro[linha, coluna] == '-'))
            {
                break;
            }
            System.Console.WriteLine("Jogada inválida");
        }
        while (true);

        if(idJogador == 1)
        {
            tabuleiro[linha, coluna] = 'X';
        }
        else 
        {
            tabuleiro[linha, coluna] = 'O';
        }
        return VerificarVitoria(tabuleiro);
    }
    static bool VerificarVitoria (char[,] tabuleiro)
    {
        for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
        {
            if(tabuleiro[linha, 0] == tabuleiro[linha, 1] && tabuleiro[linha, 1] == tabuleiro[linha, 2])
            {
                return true;
            }
        }
        for (int coluna = 0; coluna < tabuleiro.GetLength(0); coluna++)
        {
            if(tabuleiro[0, coluna] == tabuleiro[1, coluna] && tabuleiro[1, coluna] == tabuleiro[2, coluna])
            {
                return true;
            }
        }
        if(tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
        {
            return true;
        }
        if(tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
        {
            return true;
        }
        return false;


    }
}