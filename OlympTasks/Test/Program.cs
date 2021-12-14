using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            string writePath = @"task3.dat";
            string writePathResalt =  @"task3.rez";

            List<string> fileArray = File.ReadLines(writePath).Where(line => !string.IsNullOrWhiteSpace(line)).SelectMany(line => line.Split(new char[] { ' ', '\t' },
                                   StringSplitOptions.RemoveEmptyEntries)).ToList();


            int k = Convert.ToInt32(fileArray[0]);
            int w = Convert.ToInt32(fileArray[2]);
            long n = Convert.ToInt32(fileArray[1]);
            int temp = 0;



            for (int i = 1; i <= w; i++)
            {
                temp += (i * k);
            }

            if (temp <= n)
            {
                TaskWriteData(writePathResalt, "0");
            }
            else
            {
                TaskWriteData(writePathResalt, (temp - n).ToString());
            }
        }

        public static void TaskWriteData(string writePath, string text)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static string TaskReadData(string path)
        {
            try
            {
                string resalt = "";
                using (StreamReader sr = new StreamReader(path))
                {
                    resalt = sr.ReadToEnd();
                }
                return resalt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return "0";

        }
    }
}

