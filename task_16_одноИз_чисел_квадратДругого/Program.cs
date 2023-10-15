/* Напишите программу, которая
    принимает на вход два числа
    проверяет является ли одно число квадратом другого (в обе стороны)
*/

System.Console.WriteLine("Первое число: "); 
int num_1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Второе число: "); 
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1*num_1 == num_2 || num_2*num_2 == num_1)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}