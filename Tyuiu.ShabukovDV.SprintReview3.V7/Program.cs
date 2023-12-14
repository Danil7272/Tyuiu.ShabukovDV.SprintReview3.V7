using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabukovDV.SprintReview3.V7.Lib;

namespace Tyuiu.ShabukovDV.SprintReview3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Шабуков Д. В. | СМАРТб-23-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Базовые навки работы в C#                                          *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #7                                                               *");
            Console.WriteLine("* Выполнил: Шабуков Д. В. | СМАРТб-23-1                                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:            *");
            Console.WriteLine("* F(x) = cos(x) + cos(x)/(x+2) - (3x)                                      *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* F(x) = cos(x) + cos(x)/(x+2) - (3x)                                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");


            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+----------+------------+");
            Console.WriteLine("|    X     |    f(x)    |");
            Console.WriteLine("+----------+------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 7:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+------------+");
            Console.ReadLine();
        }
    }
}
