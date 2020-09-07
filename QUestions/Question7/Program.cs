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
        public static void editBytes(byte[] arr)
        {


            int leftShiftAmount = 0;
            int i = 7;//We trancate at every 7th byte in the byte[]
            for (i = 7; i < arr.Length; i += 7)
            {
                memmove(arr[i] - leftShiftAmount, arr[i + 1], sizeof(byte) * 4);  //memmove() is similar to memcpy() as it also copies data from a source to destination. this is a c++ method no c# equivalent
                leftShiftAmount++;
            }
            int clearIndex = i - 7 - leftShiftAmount + 4;
            for (clearIndex = i - 7 - leftShiftAmount + 4; clearIndex < arr.Length; clearIndex++)
            {//clear the garbage at the end, or you can just truncate up to this point
                arr[clearIndex] = 0;//clears occurs here to the byte[] at the clearIndex index
            }
        }

        private static void memmove(int v1, byte v2, int v3)
        {
            throw new NotImplementedException();
        }


        public static void Main()
        {
            // Specify a file to read from and to create.
            string pathSource = @"c:\tests\newfile.txt";
            string pathNew = @"c:\tests\newfile.txt";
            try
            {
                using (FileStream fsSource = new FileStream(pathSource,
                    FileMode.Open, FileAccess.Read))
                {
                    // Read the source file into a byte array.
                    byte[] bytes = new byte[fsSource.Length];
                    int numBytesToRead = (int)fsSource.Length;
                    int numBytesRead = 0;
                    editBytes(bytes); // this is where the magic happens
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);
                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;
                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;
                    // Write the byte array to the other FileStream.
                    using (FileStream fsNew = new FileStream(pathNew,
                        FileMode.Create, FileAccess.Write))
                    {
                        fsNew.Write(bytes, 0, numBytesToRead);
                    }
                }
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }
        }

    }
}

