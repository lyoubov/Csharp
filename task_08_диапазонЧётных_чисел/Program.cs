/* Напишите метод PrintEvenNumbers, который на вход принимает число (number), 
а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.*/

System.Console.WriteLine("Введите число от 1: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i = i + 2)  // цикл включает: условие входа, условие выхода, шаг
{
    System.Console.Write(i + "\t");
}