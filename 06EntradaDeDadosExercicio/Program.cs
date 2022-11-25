using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Entre com seu nome completo: ");
        string nomeCompleto = Console.ReadLine();
        Console.WriteLine("Quantos quartos tem na sua casa: ");
        int quartosCasa = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Entre com o preço de um produto: ");
        double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(nomeCompleto);
        Console.WriteLine(quartosCasa.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));*/

        Console.WriteLine("Entre com seu nome, idade e altura (mesma linha): ");
        string[] vet = Console.ReadLine().Split(' ');

        string nome = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

        Console.WriteLine("******************");
        Console.WriteLine(nome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
    }
}