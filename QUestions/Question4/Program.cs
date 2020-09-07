using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUestions.Question4
{
    class Program
    {
        public static int GetsumIntArray(string[] arr, int count = 0)
        {
            var value = 0;
            if (arr[count] != null)
            {
                if (arr[count].GetType() == typeof(int))
                {  // type check    
                    value = int.Parse(arr[count]);
                }
                return (value + GetsumIntArray(arr, count + 1)); //Throws an index out of  range exception
            }
            return value;
        }

        public static void Main(string[] args)
        {
            var testarray = new string[] { "okay", "null", "Tlholo", "6", "lol", "4", "six", "happy", "9" };

            Console.WriteLine("Sum of integers in string array {0}", GetsumIntArray(testarray));
            Console.ReadKey();

        }
    }

}
