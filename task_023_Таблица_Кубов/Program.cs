/*
Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и 
выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
N = 3  -> 1, 8, 27

N = 5  -> 1, 8, 27, 64, 125
*/
System.Console.WriteLine("Введите выбранный критерий: ");
int num1 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num1; i = i + 1)
{
    System.Console.WriteLine($"{i} * {i} * {i} = {Math.Pow (i, 3)}");
}