//***********************************************************************
//* Практическая работа № 7                                             *
//* Выполнила: Кондратюк Е.С., группа 2ИСП                              *
//* Задание: Высокоуровневые языки програмирования                      *
//***********************************************************************
using System;
namespace pr.r._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №7";
            try
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Здравствуйте!");
                int n, i = 1;
                double Y = 0, sum_sin = 0;
                Console.WriteLine("Введите натуральное число");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    for (i = 1; i <= n; i++) // цикл от 1 до N
                    {
                        sum_sin += Math.Sin(i); // суммируем синусы
                        Y += 1 / sum_sin; // прибавляем к Y 1 деленную на сумму синусов
                    }
                    Y = Math.Round(Y, 4);
                    Console.WriteLine($"Y = {Y} ");
                }
                else
                {
                    throw new FormatException("Это не натуральное число!");
                }
            }
            catch (FormatException fex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: " + fex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: " + aoorex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
            }
        }
    }
}