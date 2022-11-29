class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite quantos números inteiros serão digitados: ");
        int numero = int.Parse(Console.ReadLine());

        int somatorio = 0;

        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine("Valor: #{0}: ", i);
            int valor = int.Parse(Console.ReadLine());
            somatorio += valor;
        }

        Console.WriteLine("Soma igual a: {0}", somatorio);
    }
}