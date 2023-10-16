/* Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой плоскости (x, y): */

System.Console.WriteLine("Введите номер четверти:");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    System.Console.WriteLine("X; Y > 0");
}
if (num == 2)
{
    System.Console.WriteLine("X > 0 и Y < 0");
}
if (num == 3)
{
    System.Console.WriteLine("X и Y  <  0");
}