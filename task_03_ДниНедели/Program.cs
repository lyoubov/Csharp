/* 3. Напишите программу, которая будет выдавать дни недели по заданному номеру.

1 -> понедельник
2 -> вторник
3 -> среда
4 -> четверг
5 -> пятница
6 -> суббота
7 -> воскресенье

*/

Console.WriteLine("Введите число: "); 
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("День недели: "); 

if (Number==1)
{
    Console.WriteLine("Понедельник");
}
else 
if (Number==2)
{
    Console.WriteLine("Вторник");
}
else 
if (Number==3)
{
    Console.WriteLine("Среда");
}
else 
if (Number==4)
{
    Console.WriteLine("Четверг");

}
else 
if (Number==5)
{
    Console.WriteLine("Пятница");
}
else
if (Number==6)
{
    Console.WriteLine("Суббота");
}
else
if (Number==7)
{
    Console.WriteLine("Воскресенье");
}
else
System.Console.WriteLine("Нет такого дня недели");
