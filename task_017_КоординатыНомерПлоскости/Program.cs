/* Напишите программу, которая принимает на вход 
координаты точки (X и Y), при этом 
X <> 0 и Y <> 0   и 
выдает номер четверти плоскости в которой находится эта точка.
х= 34,  у= -30   ->    4
х= 2,   у= 4     ->    1
х= -34, у=-30    ->    3        */

System.Console.WriteLine("Введите данные X");
int numX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите данные Y");
int numY = Convert.ToInt32(System.Console.ReadLine());

if (numX > 0 && numY > 0)
{
    System.Console.WriteLine("1я четверть");
}
if (numX > 0 && numY < 0)
{
    System.Console.WriteLine("4я четверть");
}
if (numX < 0 && numY < 0)
{
    System.Console.WriteLine("3я четверть");
}