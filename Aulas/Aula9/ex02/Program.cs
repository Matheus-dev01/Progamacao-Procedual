using System;

	class Program
	{
		static void Main(string[] args)
		{
		  int QuantidadePositivos = 0;
		  int QuantidadeNegativos = 0;
		  int QuantidadeZero = 0;
		  
      for (int contador = 1; contador <= 10; contador ++)
        {
        int numeroDigitado = int.Parse(Console.ReadLine());

        if (numeroDigitado < 0)
        {
          QuantidadeNegativos++;
        }
        else if (numeroDigitado > 0)
        {
          QuantidadePositivos++;
        }
        else 
        {
          QuantidadeZero++;
        }
      }
      Console.WriteLine("Numeros positivos: " + QuantidadePositivos);
      Console.WriteLine("Numeros negativos: " + QuantidadeNegativos);
      Console.WriteLine("Zero(s): " + QuantidadeZero);
		}
	}