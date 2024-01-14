namespace NumerosInteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            // Nas expressoes da matemática, acontece primeiro a multiplicação e divisão
            int d = 5;
            int e = 4;
            int f = 2;
            int g = d + e * f;
            Console.WriteLine(g);

            // Para calcular primeiro a soma, devo utilizar o sinal de parênteses
            int h = 5;
            int i = 4;
            int j = 2;
            int k = (h + e) * j;
            Console.WriteLine(k);

            int l = 5;
            int m = 4;
            int n = 2;
            int o = (l + m) - 6 * n + (12 * 4) / 3 + 12;
            Console.WriteLine(k);

        }
    }
}
