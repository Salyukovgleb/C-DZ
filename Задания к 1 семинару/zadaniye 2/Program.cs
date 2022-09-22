using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. */
            /*Сначала объявляем переменные*/
            double firstnum;
            double secnum;
            /*Вводим данные с клавиатуры и конвертируем в тип дабл*/
            Console.WriteLine("Enter first number: ");
            firstnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secnum = Convert.ToDouble(Console.ReadLine());
            /*Само условие. Цифры в фигурных скобках обозначают переменные, указаные после запятой */
            if (firstnum > secnum)
            {
                Console.WriteLine("Number {0} bigger then {1}",firstnum, secnum);
            }
            else if(secnum > firstnum)
            {
                Console.WriteLine("Number {0} bigger then {1}", secnum, firstnum);
            }
            else
            {
                Console.WriteLine("Number {0} equals to {1}", firstnum, secnum);
            }
        }
    }
}