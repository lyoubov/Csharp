﻿/*7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите число Number: "); 
int usernumber = Convert.ToInt32(Console.ReadLine());

int result = usernumber % 10;
System.Console.WriteLine(result);

