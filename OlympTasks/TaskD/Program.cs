using System;

namespace TaskD
{
    class Program
    {
        static void Main(string[] args)
        {
           int year = Convert.ToInt32(Console.ReadLine());


            int temp = year;

            for (int i = year; i < 9000; i++)
            {
                temp++;
                int fourth = temp % 10;
                int third = temp % 100 / 10;
                int second = temp % 1000 / 100;
                int first = temp % 10000 / 1000;

                if (first != second && first != third && first !=fourth && second != third && second != fourth && third != fourth){
                    Console.WriteLine(temp);
                    break;
                }
            }


        }
    }
}
