using System;

namespace CSharpLess
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Имя: ");
              string name = Console.ReadLine();
              if(name == "Anatoly")
              {
                  Console.WriteLine($"Welcome, {name}!");
              }
              else if(name == "SexGodBoy")
              {
                  Console.WriteLine($"Welcome, {name}!");
              }
              else
              {
                  Console.WriteLine("This incorrect name!");
              }
           
            int a, b;
            string var, var2;
            Console.WriteLine("Введите два числа: ");
            var = Console.ReadLine();
            var2 = Console.ReadLine();

            a = Convert.ToInt32(var);
            b = Convert.ToInt32(var2);
            Console.WriteLine($"Sum variable: {a + b}");

            string var_d = "0.7";
            Convert.ToDouble(var_d);
            

           string a_s = "7";
            string a_s2 = "5";
            int a1 = int.Parse(a_s);
            int b1 = int.Parse(a_s2);
            Console.WriteLine(a + b);
            Console.ReadLine();
            


        }
    }
}
