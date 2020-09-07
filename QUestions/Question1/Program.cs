using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUestions.Question1
{
    class Program
    {
        public static bool IsDivisible(int x, int n)
        {
            return (x % n) == 0;
        }

        public static void Main(string[] args)
        {

            for (int i = 1; i < 100; i++)//iterate frome 1 to 99
            {
                if (IsDivisible(i, 21))//the same as IsDivisible(i, 3) && IsDivisible(i, 7)
                {
                    Console.WriteLine("OpenSource");
                }
                else if (IsDivisible(i, 3))
                {
                    Console.WriteLine("Open");
                }
                else if (IsDivisible(i, 7))
                {
                    Console.WriteLine("Source");
                }
                else
                {
                    Console.WriteLine(i);

                }

            }

            Console.ReadKey();
        }

    }
}
