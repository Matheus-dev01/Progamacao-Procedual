class Program 
{
    static void Main(string[] args)
    {
        const int TAMANHO_OITAVA = 7;
        const int TAMANHO_CASA = 4;
        int contador = 1;
        int casaNota = 1;
        while (casaNota <= TAMANHO_CASA)
        {
        while (contador <= TAMANHO_OITAVA)
        {
            Console.WriteLine($"{casaNota} , {contador}");
            Piano.ReproduzTecla(casaNota,contador);
            contador++;
        }
            contador--;
            contador--;
            contador--;
            contador--;
            contador--;
            contador--;
            contador--;
            casaNota++;
        }

    }
}