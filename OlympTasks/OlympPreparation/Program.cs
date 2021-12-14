using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OlympPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = Directory.GetCurrentDirectory();
            string writePath = @"task2.dat";
            string writePathResalt = @"task2.rez";


            List<string> fileArray = File.ReadLines(writePath).Where(line => !string.IsNullOrWhiteSpace(line)).SelectMany(line => line.Split(new char[] { ' ', '\t' },
                                  StringSplitOptions.RemoveEmptyEntries)).ToList();

            long sum = 0;

            foreach (var item in fileArray)
            {
                sum += Convert.ToInt32(item);
            }

            Console.WriteLine(sum);

            TaskWriteData(writePathResalt, sum.ToString());

           

        }

        public static void TaskWriteData(string writePath, string text)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
                //Console.WriteLine("writing end");
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
                //Console.WriteLine("Reading end");
                return resalt;
                //// асинхронное чтение
                //using (StreamReader sr = new StreamReader(path))
                //{
                //    Console.WriteLine(await sr.ReadToEndAsync());
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return "0";

        }
    }
}
