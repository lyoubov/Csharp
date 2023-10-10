/* Дни недели по номерам

3 -> среда
5 -> пятница
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
System.Console.WriteLine("Нет такого дня недели");
