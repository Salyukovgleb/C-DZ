using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.  */
            double firstnum;
            /*Вводим данные с клавиатуры и конвертируем в тип дабл*/
            Console.WriteLine("Enter a number: ");
            firstnum = Convert.ToDouble(Console.ReadLine());
            int a = 1;
            while(a <= firstnum)
            {
                if (a%2 == 0)
                {
                    Console.WriteLine(a);

                }
                a++;
            }
        }
    }
}