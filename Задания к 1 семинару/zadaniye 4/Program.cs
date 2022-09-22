using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. */
            double firstnum;
            double secnum;
            double thirdnum;
            /*Вводим данные с клавиатуры и конвертируем в тип дабл*/
            Console.WriteLine("Enter first number: ");
            firstnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            thirdnum = Convert.ToDouble(Console.ReadLine());
            /*Само условие. Цифры в фигурных скобках обозначают переменные, указаные после запятой */
            if (firstnum >= secnum && firstnum >= thirdnum)
            {
                Console.WriteLine("Number {0} is the biggest",firstnum);
            }
            else if(secnum > firstnum && secnum >= thirdnum)
            {
                Console.WriteLine("Number {0} is the biggest", secnum);
            }
            else
            {
                Console.WriteLine("Number {0} is the biggest", thirdnum);
            }
        }
    }
}