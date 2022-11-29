//Encerrar programa com número negativo

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite um número: ");
        double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (numero >= 0.0)
        {
            double raiz = Math.Sqrt(numero);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Digite outro número: ");
            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        Console.WriteLine("Número negativo!");
    }
}