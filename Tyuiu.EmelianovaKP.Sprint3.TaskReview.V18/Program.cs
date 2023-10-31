using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.EmelianovaKP.Sprint3.TaskReview.V18.Lib;

namespace Tyuiu.EmelianovaKP.Sprint3.TaskReview.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Емельянова К. П. | ПКТб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Review                                                            *");
            Console.WriteLine("* Задание #TaskReview                                                              *");
            Console.WriteLine("* Вариант #18                                                            *");
            Console.WriteLine("* Выполнил: Емельянова К. П. | ПКТб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = -5;
            int endValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + endValue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] array = ds.GetMassFunction(startValue, endValue);

            Console.WriteLine("+------------+------------+");
            Console.WriteLine("|      X     |    f(x)    |");
            Console.WriteLine("+------------+------------+");

            foreach (double i in array)
            {
                Console.WriteLine("|{0,7:d}     |  {1, 7:f2}   |", startValue++, i);
            }

            Console.WriteLine("+------------+------------+");
            Console.ReadKey();
        }
    }
}
