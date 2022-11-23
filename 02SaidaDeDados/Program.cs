using System;
using System.Globalization; // Definir como formatar o número

class SaidaDeDados
{
    static void Main(string[] args)
    {
        double x = 10.35784;
        int y = 32;
        string z = "Maria";
        char w = 'F';

        Console.WriteLine("Bom dia!");
        Console.Write("Bom tarde!");

        Console.WriteLine();
        Console.WriteLine(x);
        Console.WriteLine(x.ToString("F2"));
        Console.WriteLine(x.ToString("F4"));
        Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // F2 para delimitar o nº de casas
        // CultureInfo.InvariantCulture imprimir "ponto" como padrão.

        Console.WriteLine();
        Console.WriteLine("RESULTADO = " + x );
        Console.WriteLine("O valor do troco é " + x + " reais");
        Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

        Console.WriteLine();
        Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w); // Concatenação

        int idade = 32;
        double saldo = 10.35784;
        string nome = "Maria";

        Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2}", nome, idade, saldo); //Placeholder

        Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2}"); //Interpolação versão >= 6 do C#
        Console.ReadLine();
        
    }
}