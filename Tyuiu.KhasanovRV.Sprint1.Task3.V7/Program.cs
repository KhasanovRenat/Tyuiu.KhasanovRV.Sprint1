using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KhasanovRV.Sprint1.Task3.V7.Lib;

namespace Tyuiu.KhasanovRV.Sprint1.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Хасанов Р. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Хасанов Ренат Владиславович | СМАРТб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу пересчета расстояния из верст в километры            *");
            Console.WriteLine("* (1 верста — это 1066,8 м). Ответ округлите до 3 знаков после запятой.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x;
            Console.WriteLine("Введите кол-во верст:");
            x = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.VerstsToKilometers(x));
            Console.ReadKey();
        }
    }
}
