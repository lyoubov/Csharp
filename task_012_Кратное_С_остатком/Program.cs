/*
напишите программу, которая 

    принимает на вход два числа и выводит: 
является ли второе число кратным первому.

    иначе выводит: 
остаток от деления.
*/

System.Console.WriteLine("Введите число 1: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 2: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = num_1 % num_2;

if (num_3 == 0)
{
    System.Console.Write("кратное");
}
else
{
    System.Console.WriteLine("остаток от деления: " + num_3 * 1);
}
