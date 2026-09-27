//***********************************************************************
//* Практическая работа № 7                                             *
//* Выполнила: Кондратюк Е.С., группа 2ИСП                              *
//* Задание: Высокоуровневые языки програмирования                      *
//***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace pr.r._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();
            int N, i = 1;
            double Y=0, sum_sin=0;
            Console.WriteLine("Введите натуральное число");
            N = Convert.ToInt32(Console.ReadLine());

            if (N > 0)
            {
                for (i = 1; i <= N; i++)
                {

                    sum_sin += Math.Sin(i);
                    Y += 1 / sum_sin;



                }
               
                Console.WriteLine($"Y = {Y} ");

            }
            else
            {
                Console.WriteLine("ошибка! это не натуральное число!");


            }
            

        }
    }
}
