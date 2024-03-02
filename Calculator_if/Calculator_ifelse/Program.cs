using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculator");
            Console.WriteLine("Birinci eded:");
            int number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci eded:");
            int number2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("emeliyyat");
            Console.WriteLine("+, -, /, *");
            char simvol = Convert.ToChar(Console.ReadLine());
            if(simvol == '+')
            {
                int a= number1 + number2;
                Console.WriteLine("cemi:" + a);
            }
            if (simvol == '-')
            {
                int b = number1 - number2;
                Console.WriteLine("ferqi:" + b);
            }
            if (simvol == '*')
            {
                int c = number1 * number2;
                Console.WriteLine("hasil:" + c);
            }
            if (simvol == '+')
            {
                int d = number1 / number2;
                Console.WriteLine("qismet:" + d);
            }

        }
    }
}
