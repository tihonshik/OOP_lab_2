using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n 1 task \n");
            Work.Types();
            Console.Write("\n 2 task \n");
            Work.Strings();
            Console.Write("\n 3 task \n");
            Work.Array();
            Console.Write("\n 4 task \n");
            Work.Cortage();

            Console.ReadKey();
        }
    }

    class Work
    {
        public static void Types()
        {
            byte a1 = 4;
            short a2 = 5;
            ushort a3 = 3;
            int a4 = 4;
            uint a5 = 5;
            long a6 = 6;
            ulong a7 = 7;
            float a8 = 7.6F;
            double a9 = 5.5;
            char a10 = 'a';
            bool a11 = true;
            decimal a12 = 100;
            string a13 = "a13";
            object a14 = 145;

            //неявное преобразование
            short b1 = a1;
            int b2 = a1;
            long b3 = a1;
            long b4 = a4;
            double b5 = a8;

            //явное преобразование 
            byte c1 = (byte)a2;
            byte c2 = (byte)a3;
            float c3 = (float)a9;
            int c4 = (int)a14;
            long c5 = (long)a12;

            //упаковка и распаковка
            int val = 5;
            object obj = val;
            int Unbox = (int)obj;

            //работа с неявно типизированное переменной
            var mas = new[] { 2, 4, 6, 8 };
            Console.WriteLine(mas.GetType());
            var mas1 = new[] { 3.6, 1.45 };
            Console.WriteLine(mas1.GetType());

            //work with Nullable
            int? x = null;
            int y = x ?? 1;
        }

        public static void Strings()
        {
            //сравнение строковых литералов
            string path1 = "ccc";
            string path2 = "qqq";
            String.Compare(path1, path2);

            string str1 = "ttt";
            string str2 = "yyy";
            string str3 = "xrr";

            string str4 = str1 + str2;
            String.Copy(str1);

            //выделение подстроки
            str2.Substring(2, 1);

            //вставка подстроки
            string str5 = str2.Insert(2, "-");
            Console.WriteLine(str5);

            //удаление подстроки 
            str3 = str3.Remove(1, 2);
            Console.WriteLine(str3);

            string empty = "";
            string khekhe = null;
            string ooo = empty + khekhe;
            bool n = empty == khekhe;

            //srtringbuilder
            StringBuilder newstr = new StringBuilder("Filipp", 20);
            newstr = newstr.Remove(1, 2);
            newstr.Append("i");
            newstr.Insert(1, "-");
            Console.WriteLine(newstr);
        }


        public static void Array()
        {
            //3) Массивы
            /*a. Создайте целый двумерный массив и выведите его на консоль
             * в отформатированном виде (матрица).*/

            int[,] nums1;
            int[,] nums2 = new int[2, 3];
            int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };

            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*b. Создайте одномерный массив строк. 
             * Выведите на консоль его содержимое, длину массива.
             * Поменяйте произвольный элемент (пользователь 
             * определяет позицию и значение). */

            string[] masString = new string[4] { "Меня ", "зовут ", "Филипп ", "Тихонович." };
            foreach (string st in masString)
            {
                Console.Write(st);
            }
            Console.WriteLine();

            Console.WriteLine("Размер массива: " + masString.Length);

            Console.Write("Введите позицию: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (masString.Length - 1 < choice)
            {
                Console.WriteLine("нет такого элемента");
            }
            else
            {
                Console.Write("Введите значение: ");
                string newValue = Console.ReadLine();
                masString[choice] = newValue;
                foreach (string st in masString)
                {
                    Console.Write(st);
                }
            }

            Console.WriteLine();

            /*c. Создайте ступечатый (не выровненный) массив вещественных 
             * чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов
             * соответственно. Значения массива введите с консоли.*/

            double[][] masDouble = new double[3][];
            masDouble[0] = new double[2];
            masDouble[1] = new double[3];
            masDouble[2] = new double[4];

            Console.WriteLine("Введите значения для элементов массива:");

            for (int i = 0; i < masDouble.Length; i++)
            {
                for (int j = 0; j < masDouble[i].Length; j++)
                {
                    //masDouble[i][j] = Convert.ToInt64(Console.ReadLine());
                    masDouble[i][j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int i = 0; i < masDouble.Length; i++)
            {
                for (int j = 0; j < masDouble[i].Length; j++)
                {
                    Console.Write($"{masDouble[i][j]}\t");
                }
                Console.WriteLine();
            }
            /*d. Создайте неявно типизированные переменные для хранения
             * массива и строки*/

            var masVarForMas = new[]
            {
                new[]{1,2,3,4},
                new[]{5,6,7,8},
            };
            var masVarForString = new[] { "Это", "массив", "для", "строк" };

        }



        public static void Cortage()
        {
            /*a. Задайте кортеж из 5 элементов с типами 
            * int, string, char, string, ulong*/
            ValueTuple<int, string, char, string, ulong> tuple1 = (18, "Filipp", 'F', "Tihonovich", 710);
            // b.Сделайте именование его элементов
            (int, string, char, string, ulong) tuple2 = (Age: 18, name: "Filipp", patronymic: 'F', surname: "Tihonovich", typeUlong: 710);
            var tuple3 = (Age: 18, name: "Filipp", patronymic: 'F', surname: "Tihonovich", typeUlong: 710);
            var (аgeForTuple, name, patronymic, surname, typeUlong) = (18, "Filipp", 'F', "Tihonovich", 710);

            Console.WriteLine("c. Выведите кортеж на консоль целиком и выборочно (1, 3, 4  элементы) ");
            Console.WriteLine(tuple1);
            Console.WriteLine($"{tuple1.Item1.ToString()},  {tuple1.Item3}, {tuple1.Item4}");
            // d.Выполните распаковку кортежа в переменные.
            var (one, two, three, four, five) = tuple1;
            Console.WriteLine($"{one}\t{two}\t{three}\t{four}\t{five}");
            // e.Сравните два кортежа. 
            Console.WriteLine(tuple1.Equals(tuple2)); // True
            (int, int, int, char) functionForTask5(int[] Mas, string Str)
            {
                int maxElem = Mas[0];
                int minElem = Mas[0];
                int sum = 0;
                char firstChar;

                foreach (int elem in Mas)
                {
                    if (maxElem < elem)
                    {
                        maxElem = elem;
                    }
                    if (minElem > elem)
                    {
                        minElem = elem;
                    }
                    sum += elem;
                }

                firstChar = Str[0];

                return (max: maxElem, min: minElem, sum: sum, first: firstChar);
            }

            int[] masOfInt = { 1, 2, 3, 4, 5, 6, 7 };
            string strForTask5 = "Привет!";
            var tupleForTask5 = functionForTask5(masOfInt, strForTask5);
            Console.WriteLine(tupleForTask5);

        }



    }
}
