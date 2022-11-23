class Casting
{
    static void Main(string[] args)
    {
        int a = 8;
        int b = 5;

        double resultado = (double) a / b;

        Console.WriteLine(resultado);


        // Conversão explícita com perda de dado
        double c;
        int d;

        c = 5.1;
        d = (int)c;

        Console.WriteLine(d);

        // Conversao implícita
        int e;
        double f;

        e = 5;
        f = e;

        Console.WriteLine(e);
    }
}