using System;

	class Program
	{
		public static void Main(string[] args)
		{
		  int ContagemProgressiva = 0;
		  int ContagemRegressiva = 50;
		  
		  while (ContagemProgressiva <= 50 && ContagemRegressiva >= 0)
			{
			  Console.WriteLine(ContagemProgressiva + " - " + ContagemRegressiva);
			  ContagemRegressiva--;
			  ContagemProgressiva++;
			}
		}
	}