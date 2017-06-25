using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int highest = highestNumber(30, 40, 50);
            int lowest = LowestNumber(20, 30, 40);
            int a = 3;
            int b = 4;
            int c = 8;
            Console.WriteLine(lowest);
            Console.WriteLine(highest);
            Console.WriteLine("odd" + oddNumber(a));
            Console.WriteLine("even" + evenNumber(a));

            Console.ReadKey();
        }
        static int LowestNumber(int a, int b, int c)
        {
            if (a < b) //if statement
            {
                return a;
            }
            else

            {
                return b;
            }
        }
        static int highestNumber(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }

            if (b > a && b > c)

            {
                return b;
            }
            else
            {
                return c;
            }
        }
        static bool oddNumber(int a)
        {
            if (a % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;

            }


        }
        static bool even(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
} 