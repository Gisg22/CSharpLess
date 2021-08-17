using System;

namespace CSharpArithmeticalMean
{
    class Program
    {
        static void Main(string[] args)
        {
            string a_s, b_s;
            int a, b;
            Console.WriteLine("Введите два числа: ");
            a_s = Console.ReadLine();
            b_s = Console.ReadLine();

            a = Convert.ToInt32(a_s);
            b = Convert.ToInt32(b_s);

            int result = (a + b) / 2;
            Console.WriteLine($"Result = {result}");
        }
    }
}
