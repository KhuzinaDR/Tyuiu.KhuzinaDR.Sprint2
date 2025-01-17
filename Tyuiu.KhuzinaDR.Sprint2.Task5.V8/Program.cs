﻿using Tyuiu.KhuzinaDR.Sprint2.Task5.V8.Lib;
namespace Tyuiu.KhuzinaDR.Sprint2.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Хузина Д. Р. | СМАРТб-24-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Хузина Диана Ранидовна | СМАРТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами: m       *");
            Console.WriteLine("* (порядковый номер месяца) и n (число). По заданным n и m определить дату*");
            Console.WriteLine("* предыдущего дня (принять, что n и m не характеризуют 1 января).         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите месяц:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.FindDateOfPreviousDay(m, n));
            Console.ReadLine();

        }
    }
}