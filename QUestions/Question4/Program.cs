using System;
using System.Collections.Generic;
using System.Linq;

namespace QUestions.Question4
{
    class Program
    {
        public static int CalSum(List<string> list)
        {

            if (list.Count == 1)
            {
                if (Int32.TryParse(list[0], out int result))
                    return result;

            }
            else
            {
                if (Int32.TryParse(list[0], out int result))
                    return result + CalSum(list.Skip(1).ToList());
            }
            return CalSum(list.Skip(1).ToList());
        }
        static void Main(string[] args)
        {
            var list2 = new List<string>() { "100", "geek", "200", "400", "for", "101", "2018", "64", "74", "geeks", "27", "7810" };
            Console.Write('['); list2.ForEach((x) => {  Console.Write('{' + $"{x}" + "},");  }); Console.Write(']');
            
            Console.WriteLine($"\n Sum of Intergers in String List: {CalSum(list2)}");
            Console.ReadKey();
        }
    }
}
