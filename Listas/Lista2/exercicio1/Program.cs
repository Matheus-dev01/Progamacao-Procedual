using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Digite o nome de usuario: ");
        string nomedeUsuario = Console.ReadLine();

        Console.WriteLine("Digite a senha: ");
        string senha = Console.ReadLine();

        if (nomedeUsuario == "admin" && senha == "123senha")
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Credenciais inválidas…");
        }

    }
}