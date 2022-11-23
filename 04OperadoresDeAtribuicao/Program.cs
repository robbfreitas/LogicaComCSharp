/*
 = | a = 10 | a recebe 10
+= | a += 2 | a recebe a + 2
-+ | a -= 2 | a recebe a - 2
*= | a *= 2 | a recebe a * 2
/= | a /= 2 | a recebe a / 2
%= | a %= 3 | a recebe a % 3
 */

class OperadoresDeAtribuicao
{
    static void Main(string[] args)
    {
        int a = 10;
        Console.WriteLine(a);

        a += 2;
        Console.WriteLine(a);

        a *= 2;
        Console.WriteLine(a);

        string s = "ABC";
        Console.WriteLine(s);

        s += "DEF";
        Console.WriteLine(s);

        //Operadores de aritméticos/atribuição - ++ e -- | a++ ou ++a | a-- ou --a

        int b = 10;
        b++;
        Console.WriteLine(b);

        int c = 10;
        int d = c++;
        Console.WriteLine(c);
        Console.WriteLine(d);

        int e = 10;
        int f = ++e;
        Console.WriteLine(e);
        Console.WriteLine(f);
    }

}