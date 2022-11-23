/*Produzir a saída no console: 
Produtos: Computador, cujo preço é $ 2100,00
Mesa de escritório, cujo preco é $ 650,50
Registro: 30 anos de idade, código 5290 e gênero: M
Medida com oito casas decimais: 53,23456700 Arredondado
(três casas decimais): 53,235
Separador decimal invariant culture: 53.235
 */

using System.Globalization;

class Exercicio
{
    static void Main(string[] args)
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 52.234567;

        Console.WriteLine($"{produto1}, cujo preço é R$ {preco1}");
        Console.WriteLine($"{produto2}, cujo preço é R$ {preco2:F2}");

        Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} " +
            $"e gênero: {genero}");

        Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
        Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
        Console.WriteLine("Separador decimal Invariante Culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
    }
}