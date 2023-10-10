// 0.Напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадратом второго.


Console.WriteLine("Введите число 1: "); 
int NumberА = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: "); 
int NumberB = Convert.ToInt32(Console.ReadLine());

if (NumberА == NumberА * NumberА)
{
    System.Console.WriteLine("Не квадрат: "); 
}
else
{
    System.Console.WriteLine("это  квадрат: ");
}
