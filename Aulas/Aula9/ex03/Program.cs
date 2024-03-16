using System;

class Program
	{
		static void Main(string[] args)
		{
      int somatorio = 0;

      int numeroDigitado = int.Parse(Console.ReadLine());

      if (numeroDigitado > 0)
      {
        for (int contador = 0; contador < numeroDigitado; contador++)
        {
          int sobra = contador % 2;
          if (sobra != 0)
          {
            somatorio = somatorio + contador;
          }
        }
        System.Console.WriteLine($"O somatorio de todos numeros impares eh: {somatorio}");
      }
      else if (numeroDigitado < 0)
      {
        for (int contador = 0; contador >= numeroDigitado; contador--)
        {
          int sobra = contador % 2;
          if (sobra == 0)
          {
            System.Console.WriteLine(contador);
          }        
        }
      }
      else 
      {
        System.Console.WriteLine("nada a fazer aqui");
      }
		}
	}