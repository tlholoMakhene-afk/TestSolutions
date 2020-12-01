using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUestions.Question7
{
    class Program
    {

        public static void Main()
        {
            try
            {
                    string fileName = @"C:\Users\pxyz6n\source\repos\Functions\Functions\Questions.bin";
                    List<byte> list;
                    using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))

                    {
                        byte[] arrfile = new byte[fs.Length];
                        fs.Read(arrfile, 0, arrfile.Length);
                        list = new List<byte>(arrfile);
                    }

                    for (int i = 0; i < list.Count(); i++)
                    {
                        if (i == 7)
                        {
                            list.RemoveAt(i);
                        }

                    }

                    byte[] resultArr = list.ToArray();

                    using (var fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        fs.Write(resultArr, 0, resultArr.Length);

                    }
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }
        }

    }
}

