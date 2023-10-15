/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */


Console.WriteLine("Введите число: "); 
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("День недели: "); 

if (Number==6 || Number==7)
{
    Console.Write("Выходные");
}
else
if (Number==1 || Number==2 || Number==3 || Number==4 || Number==5)
{
Console.Write("Будни");
}
else
System.Console.WriteLine("Нет такого дня недели");