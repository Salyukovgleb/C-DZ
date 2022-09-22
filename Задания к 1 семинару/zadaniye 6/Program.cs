using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). */
            double firstnum;
            /*Вводим данные с клавиатуры и конвертируем в тип дабл*/
            Console.WriteLine("Enter a number: ");
            firstnum = Convert.ToDouble(Console.ReadLine());
            /*Само условие. Цифры в фигурных скобках обозначают переменные, указаные после запятой */
            if (firstnum%2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number isn't even");
            }
        }
    }
}