using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QUestions.Question8
{
    class Program
    {

        // Main Method 
        static void Main(string[] args)
        {
            // Input strings to Match 
            // valid mobile number 
            string[] str = {"9925612824",
          "8238783138", "Odoo Rules"};

            foreach (string s in str)
            {
                Console.WriteLine("it is {1} that this {0} contains Odoo and rules.", s,
                            StringCheck(s));
            }

            Console.ReadKey();
        }

        // method containing the regex 
        public static bool StringCheck(string inputstring)
        {
            string strRegex = @"^(?=.*Odoo)(?=.*#rules).*$";

            // Class Regex Repesents an 
            // immutable regular expression. 
            //   Format                Pattern 
            // xxxxxxxxxx           ^[0 - 9]{ 10}$ 
            // +xx xx xxxxxxxx     ^\+[0 - 9]{ 2}\s +[0 - 9]{ 2}\s +[0 - 9]{ 8}$ 
            // xxx - xxxx - xxxx   ^[0 - 9]{ 3} -[0 - 9]{ 4}-[0 - 9]{ 4}$ 
            Regex re = new Regex(strRegex);

            // The IsMatch method is used to validate 
            // a string or to ensure that a string 
            // conforms to a particular pattern. 

             var result = re.Match(inputstring);

            return result.Success;
           
        }
    }
}
