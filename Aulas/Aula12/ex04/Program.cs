using System;

class Program
{
    static void Main(string[] args)
    {
        string[,] Matriz = new string[4,3];

        for (int Usuarios = 0; Usuarios < 4; Usuarios++)
        {
            for (int DadosUsuarios = 0; DadosUsuarios < 3; DadosUsuarios++)
            {
                Matriz[Usuarios, DadosUsuarios] = Console.ReadLine();
            }
        }
        for (int Usuarios = 3; Usuarios >= 0; Usuarios--)
        {
            for (int DadosUsuarios = 0; DadosUsuarios < 3; DadosUsuarios++)
            {
                System.Console.WriteLine(Matriz[Usuarios, DadosUsuarios]);
            }
        }
    }
}