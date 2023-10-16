/* Напишите программу, которая 
принимает на вход число (N) и 
выдает таблицу квадратов чисел от 1 до N 

5 -> 1, 4, 9, 16, 25
2 -> 1, 4                       */

System.Console.WriteLine("Введите выбранный критерий: ");
int num1 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num1; i = i + 1)
{
    System.Console.WriteLine($"{i} * {i} = {Math.Pow (i, 2)}");
}
