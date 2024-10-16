using Tyuiu.KhuzinaDR.Sprint2.Task6.V1.Lib;

namespace Tyuiu.KhuzinaDR.Sprint2.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Хузина Д. Р. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Хузина Диана Ранидовна | СМАРТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Условие: По данному номеру месяца, определите количество дней в этом    *");
            Console.WriteLine("* месяце.                                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца:");
            int NumberOfMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if ((NumberOfMonth < 1) || (NumberOfMonth > 12))
            {
                Console.WriteLine("Указано неверное значение. Укажите значение от 1 до 12.");
            }

            else
            {
                Console.WriteLine($"Количество дней в месяце : {ds.FindMonthDaysCount(NumberOfMonth)}");
            }
        }
    }
}