using System;

class Program
{
    static void Main (string[] args)
    {
        string usuario = "admin";
        string senha = "123senha";
        int contador = 1;

        do
        {
            System.Console.WriteLine("Digite o usuario de login: ");
            string tentativaUsuario = Console.ReadLine();

            System.Console.WriteLine("Digite a senha de login: ");
            string tentativaSenha = Console.ReadLine();

            if (tentativaUsuario == usuario && tentativaSenha == senha)
            {
                System.Console.WriteLine("Login realizado com sucesso");
                break;
            }
            else
            {
                contador++;
            }
        }
        while (contador <= 3);
        if (contador >= 3)
        {
            System.Console.WriteLine("Sua conta foi bloqueada");
        }        
    }
}