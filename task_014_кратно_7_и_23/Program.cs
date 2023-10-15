/* Напишите программу, которая 
    принимает на вход число  
        и
    принимает кратно ли оно одновременно 7 и 23

***   и = &&
*** или = ||
*/

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("кратно!!!!!!");
}
else
{
    System.Console.WriteLine("не вариант");
}