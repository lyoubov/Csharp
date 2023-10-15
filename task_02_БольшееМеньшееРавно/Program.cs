/*Внутри класса Answer напишите метод CompareNumbers, 
который на вход принимает два числа 
и выводит, какое число большее, а какое меньшее.

    firstNumber: '5'
    secondNumber: '6'
Первое число `5` меньше чем второе число `6`

    firstNumber: '3'
    secondNumber: '3'
Введенные числа равны `3`
*/

System.Console.WriteLine("Укажите number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Укажите number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2)
{
    System.Console.WriteLine("Первое число " + number1 + " меньше чем второе " + number2);
}
else
if (number2 < number1)
{
    System.Console.WriteLine("Первое число " + number1 + " больше чем второе " + number2);
}
else
if (number1 == number2)
{
    System.Console.WriteLine("Введенные числа равны " + number1);
}