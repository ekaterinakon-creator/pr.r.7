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
                double Y = 0, sumSin = 0;
                Console.Write("Введите натуральное число: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    for (i = 1; i <= n; i++) // цикл от 1 до N
                    {
                        sumSin += Math.Sin(i); // суммируем синусы
                        if (Math.Abs(sumSin) < 0.000001)
                        {
                            Console.WriteLine("Сумма синусов = 0. Делить на 0 нельзя!");
                            break;
                        }
                        Y += 1 / sumSin; // прибавляем к Y 1 деленную на сумму синусов
                    }
                    
                    Console.WriteLine($"Y = {Math.Round(Y, 4)}");
                }
                else
                {
                    throw new FormatException("Это не натуральное число!");
                }
            }
            catch (FormatException fex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ошибка: " + fex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ошибка: " + aoorex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            }
            catch (OverflowException oex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: " + oex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ошибка: " + ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }
}