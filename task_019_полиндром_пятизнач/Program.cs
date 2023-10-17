/*
Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и 
проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
Для остальных чисел вернуть True или False.

14212 -> False
12821 -> True
234322 -> Число не пятизначное False */

/*                      Вариант 1
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 10000;
//System.Console.WriteLine(num1);
int num2 = num / 1000 % 10;
// System.Console.WriteLine(num2);
int num4 =num/ 10 % 10;
// System.Console.WriteLine(num4);
int num5 = num % 10;
// System.Console.WriteLine(num5);

if (num >= 10000 & num <= 99999)
{
    if(num1 == num5 & num2 == num4)
    {   
        System.Console.WriteLine("True");
    }
    else 
    System.Console.WriteLine("Fals");
}
else
{
    System.Console.WriteLine("не пятизначное");
}                   */

// перевернуть число n
System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int rev_N = 0;
for (int i = N; i > 0; i = i / 10)
{
    rev_N = rev_N * 10 + i % 10;
    System.Console.WriteLine(rev_N);
}
