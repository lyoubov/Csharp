/*напишите метод, который на вход принимает число number и 
выводит, является ли число чётным (делится ли оно на два без остатка).
6-> четное
3-> нечетное
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;

if (result == 0)
{
    System.Console.WriteLine("Четное");
}
if (result == 0)
{
    System.Console.WriteLine("Это число 0");
}
else 
System.Console.WriteLine("Не четное");