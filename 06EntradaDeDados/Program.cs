using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        /*string entrada = Console.ReadLine();
        Console.WriteLine(entrada);*/

        string[] v = Console.ReadLine().Split(' ');
        string a = v[0];
        string b = v[1];
        string c = v[2];

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        // Parte 2

        int n1 = int.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Você digitou");
        Console.WriteLine(n1);
        Console.WriteLine(ch);
        Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
    }
}

