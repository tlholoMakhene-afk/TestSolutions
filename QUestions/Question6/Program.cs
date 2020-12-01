using System;
using System.IO;
using System.Net;

namespace QUestions.Question6
{
    class Program
    {


        public static void Main(string[] args)
        {
            WebClient wc = null;
            try
            {
                Uri uri = new Uri(@"https://www.sap.com/belgique/index.html");
                wc = new WebClient();
                var resultData = wc.DownloadString(uri);
                String line;
                string[] splittedData = resultData.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                int counter = 0;
                using (StreamWriter file = File.CreateText(@"C:\Desktop\data.html"))
                {
                    while (counter < splittedData.Length && (line = splittedData[counter]) != null)
                    {
                        file.Write(line.Replace("SAP", "Odoo"));
                        counter++;
                    }

                }

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                wc?.Dispose();
            }

        }
    }

}