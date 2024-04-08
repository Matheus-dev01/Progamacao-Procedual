using System;
class Program
{
    static bool Login(string nomeUsuario, string senha)
    {
        if (nomeUsuario == "admin" && senha == "senha123")
        {
            return true;
        }
        return false;
    }

    static void Main(string[] args)
    {
        string nomeUsuario = Console.ReadLine();
        string senha = Console.ReadLine();

        if (Login(nomeUsuario, senha))
        {
            System.Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            System.Console.WriteLine("Falha no login");
        }
    }
}