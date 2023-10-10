/* Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

Console.WriteLine("Введите число Number: "); 
int Number = Convert.ToInt32(Console.ReadLine());

for (int i = -Number; i < Number; i = i + 1)

Console.Write(i + " ");
