using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUestions.Question3
{
    class Program
    {

        public static int GetSum(string[] array)
        {
            var sum = 0;
            foreach (var item in array)
            {
                int result = 0;//in order to use the TryParse you need a result var
                if (int.TryParse(item, out result))//statement taken seriously about value should represent an interger
                {
                    sum += result;//sucessful
                }
            }
            return sum;
        }

        public static void Main(string[] args)
        {
            var testarray = new string[] { "okay", "null", "Tlholo", "6", "lol", "4", "six", "happy", "9" };
            Console.WriteLine("Sum of integers in string array: {0}", GetSum(testarray));
            Console.ReadKey();
        }
    }
}
