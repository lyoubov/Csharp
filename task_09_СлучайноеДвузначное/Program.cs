﻿/*
9. Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8
*/

int number = new Random().Next(10, 100);
System.Console.WriteLine(number);

int first = number / 10;
int last = number % 10;

if (first > last)
{
    System.Console.Write("наибольшее " + first);
}
else 
System.Console.Write("наибольшее " + last);