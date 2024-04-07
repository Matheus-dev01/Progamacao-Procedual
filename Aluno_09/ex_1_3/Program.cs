using System;

class Prorgam
{
    public static void Main(string[] args)
    {
        double MediaAluno = 0;
        for (int contador = 0; contador < 4; contador++)
        {
            double NotaAluno = Convert.ToDouble(Console.ReadLine());
            MediaAluno += NotaAluno;
        }

        MediaAluno = MediaAluno / 4;
        if (MediaAluno >= 5)
        {
            System.Console.WriteLine("Aluno aprovado");
        }
        else if (MediaAluno >= 3 && MediaAluno < 5)
        {
            System.Console.WriteLine("Aluno em recuperacao");
        }
        else if (MediaAluno < 3)
        {
            System.Console.WriteLine("Aluno reprovado");
        }
    }
}