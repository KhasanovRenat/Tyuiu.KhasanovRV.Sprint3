using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Tyuiu.KhasanovRV.Sprint3.Task7.V16.Lib;

namespace Tyuiu.KhasanovRV.Sprint3.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Хасанов Р. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Хасанов Ренат Владиславович | СМАРТб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = сos(x) / (x - 0.4) + sin(x) * 8 * x + 2                          *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном промежутке [-5;5] с шагом 1.*");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.     *");
            Console.WriteLine("* Значения занести в массив. Значения округлить до 2 знаков после запятой *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5, stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            double[] res = ds.GetMassFunction(startValue, stopValue);
            int len = res.Length;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine("|{0,6:d}    |  {1 ,6:f2}  |", startValue, res[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");


            Console.ReadKey();
        }
    }
}
