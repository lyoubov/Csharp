﻿/*Внутри класса Answer напишите метод FindMax, который 
принимает на вход три числа и 
выдаёт максимальное из этих чисел. 
 */

System.Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
System.Console.WriteLine("Максимальное из этих чисел: " + max);

