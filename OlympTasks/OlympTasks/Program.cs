using System;
using System.Collections.Generic;
using System.IO;

namespace OlympTasks
{
    class Program
    {
        public struct Coords
        {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; }
            public double Y { get; }

            public override string ToString() => $"({X}, {Y})";
        }

        static void Main(string[] args)
        {
            //Тут розкоментовувати задачі

            //Task1();

             //Task2();

            //Task3();

            //Task4();

            Task5();






            //string data = "";
            //data = TaskReadData(writePath);

            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] == ' ')
            //    {
            //        temp++;

            //        if (temp == 1)
            //        {
            //            k = Convert.ToInt32(temp_str);
            //            temp_str = "";
            //        }
            //        else 
            //        {
            //            n = Convert.ToInt32(temp_str);
            //            temp_str = "";
            //        }

            //    }
            //    else 
            //    {
            //        temp_str += data[i];
            //    }

            //}

            //w = Convert.ToInt32(temp_str);

























            //string text = "1 2 3 4";

            //TaskWriteData(writePath, text);

            //string data = "";
            //data = TaskReadData(writePath);


            //int sum = 0;

            //bool flag1 = true;
            //int k = 0;
            //int temp;


            //do
            //{

            //    string number = "";


            //    do
            //    {
            //        flag1 = true;

            //        if (data[k] != ' ')
            //        {
            //            number += data[k++];

            //            //if (data[k] == 'к')
            //            //{
            //            //    flag1 = false;
            //            //}
            //            if (data[k] == ' ')
            //            {
            //                k++;
            //                flag1 = false;
            //            }
            //            else if(!int.TryParse(data[k].ToString(), out temp))
            //            {
            //                flag1 = false;
            //            }

            //        }
            //        else
            //        {
            //            flag1 = false;
            //        }

            //    } while (flag1);

            //    if (number != "")
            //    {
            //        sum += Convert.ToInt32(number); //long.Parse(number);
            //    }




            //}
            //while (int.TryParse(data[k].ToString(), out temp)||int.TryParse(data[k+1].ToString(), out temp));


            //TaskWriteData(writePathResalt, sum.ToString());

        }

        public static void Task1()
        {
            try
            {
                var input = string.Empty;
                var inputValue = (uint)0;
                //enter
                do
                {
                    Console.Write("Введите трёхзначное число: ");
                    input = Console.ReadLine();
                    //null input
                    if (input.Length != 0)
                    {

                        if (uint.TryParse(input, out inputValue))
                        {
                            //check
                            if (inputValue > 99 && inputValue < 1000)
                            {
                                break;
                            }
                        }
                    }
                } while (true);
                //Сотні
                var hundreds = inputValue / 100;
                //Десятки
                var tens = (inputValue - hundreds * 100) / 10;
                //Одниці
                var digits = inputValue - hundreds * 100 - tens * 10;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} = {1}+{2}+{3} = {4}.", inputValue, hundreds, tens, digits, hundreds + tens + digits);
                Console.ResetColor();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Try again! Incorrect number. " + ex.Message);
            }
        }

        public static void Task2()
        {
            try
            {
                double x = 0;
                do
                {
                    Console.WriteLine("Enter X(from -2sqrt2 to 0 and from -2sqrt2 to +...): ");
                    x = Convert.ToDouble(Console.ReadLine());
                } while (x < -2 * Math.Sqrt(2) || (x >= 0 && x < 2 * Math.Sqrt(2)));
                //&& (x >= 0 || x < 2 * Math.Sqrt(2))
                double y = 0;
                do
                {
                    Console.WriteLine("Enter Y(must != 0): ");

                    y = Convert.ToDouble(Console.ReadLine());
                } while (y == 0);

                double temp1 = (x * x * x) / 3 * y;
                double temp2 = Math.Sqrt((x * x * x) - 8 * x);
                double temp3 = (3 * Math.Sin(y)) / Math.Cos((x / y));
                Console.WriteLine("Part1: " + temp1);
                Console.WriteLine("Part2: " + temp2);
                Console.WriteLine("Part3: " + temp3);
                double resalt = temp1 + temp2 + temp3;
                Console.WriteLine(resalt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Task3()
        {
            Console.WriteLine("Enter X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x == 22)
            {
                double resalt = x;
                double temp = 3;
                bool flag = true;

                for (int i = 0; i < 9; i++)
                {
                    if (flag)
                    {
                        resalt -= (Math.Pow(x, temp) / temp);

                        flag = false;
                    }
                    else
                    {
                        resalt += (Math.Pow(x, temp) / temp);
                        flag = true;
                    }
                    temp += 2;
                    Console.WriteLine("temp:" + temp);
                    //Console.WriteLine("add 2+:" + i);
                }

                Console.WriteLine("resalt: " + resalt);
            }
        }

        #region Task4
        
        public static void Task4()
        {
            int[,] nums2 = { { 22, 215, 0, -4, 28, 125 }, { 87, 44, -22, 7, 123, -39 }, { -9, -5, 0, 63, -17, 45 }, { 21, -3, -4, -8, 9, -122 }, { -21, -8, -5, 45, 32, 77 } };


            int rows = nums2.GetUpperBound(0) + 1;
            int columns = nums2.Length / rows;

            ShowMatrix(nums2);

            Console.WriteLine("Specific sums (number > 0 %2==0):"+SpecificSums(nums2));

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (nums2[i, j] < 0)
                    {
                        nums2[i, j] = 0;
                    }
                    else if (nums2[i, j] > 0)
                    {
                        nums2[i, j] = 1;
                    }
                }

            }

            ShowMatrix(nums2);
        }

        public static void ShowMatrix(int[,] nums2)
        {
            int rows = nums2.GetUpperBound(0) + 1;
            int columns = nums2.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{nums2[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        public static double SpecificSums(int[,] nums2)
        {
            double res = 0;
            int rows = nums2.GetUpperBound(0) + 1;
            int columns = nums2.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (nums2[i, j] > 0)
                    {
                        if (nums2[i, j] % 2 == 0)
                        {
                            res += (nums2[i, j] * nums2[i, j]);
                        }
                    }

                }

            }

            return res;
        }

        #endregion

        #region Task 5
        public static void Task5()
        {
            string writePath = @"D:\DANO.txt";
            string writePathResalt = @"D:\RESULT.txt";

            string path = Directory.GetCurrentDirectory();
             writePath = path+ @"\DANO.txt";
             writePathResalt = path +  @"\RESULT.txt";

            string text = "55 37, 12 17, 77 -10";
            Task5WriteData(writePath, text);

            string data = Task5ReadData(writePath);

            double triangleSquare = 0;

            List<Coords> list_cootds = new List<Coords>();

            string str = data;
            for (int i = 0; i < 3; i++)
            {
                string num1 = "", num2 = "";
                num1 = GetNumberFromString(str);
                str = StringCutNumber(str);
                num2 = GetNumberFromString(str);
                str = StringCutNumber(str);

                Console.WriteLine(num1 + " " + num2);

                list_cootds.Add(new Coords(Convert.ToDouble(num1), Convert.ToDouble(num2)));
            }


            double triangleAB = FindTriangleLength(list_cootds, 0, 1);
            double triangleBC = FindTriangleLength(list_cootds, 1, 2);
            double triangleCA = FindTriangleLength(list_cootds, 2, 0);


            Console.WriteLine("a = " + triangleAB + "; b = " + triangleBC + "; c = " + triangleCA);

            double triangleP = triangleAB + triangleBC + triangleCA;
            double temp = triangleP * (triangleP - triangleAB) * (triangleP - triangleBC) * (triangleP - triangleCA);

            Console.WriteLine("Check resalt in RESULT.txt");
            //Формула герона
            triangleSquare = Math.Sqrt(temp);

            Task5WriteData(writePathResalt, triangleSquare.ToString());
        }

        public static double FindTriangleLength(List<Coords> list_cootds, int point1, int point2)
        {
            double temp1 = list_cootds[point2].X - list_cootds[point1].X;
            temp1 *= temp1;

            double temp2 = list_cootds[point2].Y - list_cootds[point1].Y;
            temp2 *= temp2;
            double res = temp1 + temp2;
            double triangleAB = Math.Sqrt(res);
            return triangleAB;
        }

        public static string StringCutNumber(string str)
        {
            string resalt = "";
            bool flag = false;
            for (int k = 0; k < str.Length; k++)
            {
                if (flag)
                {
                    resalt += str[k];
                }

                if (str[k] == ' ' || str[k] == ',')
                {
                    flag = true;

                    if (str[k] == ',' && str[k + 1] == ' ')
                    {
                        k += 1;
                    }

                }
            }

            return resalt;

        }

        public static string GetNumberFromString(string str)
        {
            string num1 = "";

            for (int k = 0; k < str.Length; k++)
            {
                if ((str[k] == ' ' || str[k] == ',') && num1 != "")
                {
                    break;
                }
                else if (str[k] != ' ')
                {
                    num1 += str[k];
                }

            }

            return num1;
        }

        public static void Task5WriteData(string writePath, string text)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
                Console.WriteLine("writing end");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static string Task5ReadData(string path)
        {
            try
            {
                string resalt = "";
                using (StreamReader sr = new StreamReader(path))
                {
                    resalt = sr.ReadToEnd();
                }
                Console.WriteLine("Reading end");
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

            return "Smg went wrong!";

        }
        #endregion

    }
}

