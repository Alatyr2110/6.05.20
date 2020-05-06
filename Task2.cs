using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    partial class Homework3
    {
        // а)  С клавиатуры вводятся числа, 
        // пока не будет введён 0 (каждое число в новой строке). 
        // Требуется подсчитать сумму всех нечётных положительных чисел. 
        // Сами числа и сумму вывести на экран, используя tryParse.
        public static void Task2()
        {
            Console.WriteLine("И здесь проблема. В отдельном файле работает, здесь нет. " +
                "Пишет: Ошибка  CS8370  Компонент 'статические локальные функции' недоступен в C# 7.3. " +
                "Используйте версию языка 8.0 или выше.");
            Console.ReadKey();

            /*static void Main() //???
            {
                var a = Int32.Parse(Console.ReadLine());
                int sum = 0;
                int i = 0;

                while (a != 0)
                {
                    if (a > 0)
                        if (a % 2 == 0)
                        {
                            sum = sum + a;
                            i++;
                        }
                    a = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine("Сумма всех четных чисел:   " + sum);
                Console.WriteLine("Всего четных чисел:   " + i);
                Console.ReadKey();
            }*/
        }
    }
}
 

