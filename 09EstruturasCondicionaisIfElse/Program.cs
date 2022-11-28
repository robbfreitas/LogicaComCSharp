class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com um número inteiro: ");
        int numeroInteiro = int.Parse(Console.ReadLine());

        if (numeroInteiro % 2 == 0)
        {
            Console.WriteLine("Número par");
        }
        else
        {
            Console.WriteLine("Número ímpar");
        }

        Console.WriteLine("Que horas são agora? ");
        double horas = double.Parse(Console.ReadLine());

        if (horas < 12)
        {
            Console.WriteLine("Bom dia!");
        }
        else if (horas < 18) 
        {
            Console.WriteLine("Boa tarde!");
        }
        else
        {
            Console.WriteLine("Boa noite");
        }
    }
}