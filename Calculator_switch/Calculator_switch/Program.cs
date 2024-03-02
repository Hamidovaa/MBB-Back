using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesgulluq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("__");
            Console.WriteLine("Calculator");
            Console.WriteLine("__");

            Console.WriteLine("Birinci eded:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ikinci eded:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Emeliyyat:");
            Console.WriteLine("\t+ : Toplama");
            Console.WriteLine("\t- : Cixma");
            Console.WriteLine("\t* : Vurma");
            Console.WriteLine("\t/ : Bolme");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"netice: {num1}+{num2}=" + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"netice: {num1}-{num2}=" + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"netice: {num1}*{num2}=" + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"netice: {num1}/{num2}=" + result);
                    break;
                default:
                    Console.WriteLine("xeta");
                    break;
            }
            Console.ReadKey();
        }
    }
}
