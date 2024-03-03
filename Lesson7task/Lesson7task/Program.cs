using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin:");
            int x1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:");
            int x2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emeliyyat daxil edin:");
            char option=Convert.ToChar(Console.ReadLine());

            if(option == '+')
            {
                Console.WriteLine(x1 + x2);
            }
            else if(option == '-')
            {
                Console.WriteLine(x1- x2);
            }
            else if(option== '*')
            {
                Console.WriteLine(x1 * x2);
            }
            else if(option=='/')
            {
                Console.WriteLine(x1 / x2);
            }
            else
            {
                Console.WriteLine("sehv emeliyyat");
            }
        }
    }
}
