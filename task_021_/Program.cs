/*
Внутри класса Answer напишите метод DistanceBetweenPoints, 
который принимает на вход координаты двух точек pointA и pointB 
в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

System.Console.WriteLine("Введите для точки А (х;у;z): ");
int AX = Convert.ToInt32(Console.ReadLine());
int AY = Convert.ToInt32(Console.ReadLine());
int AZ = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите для точки В (х;у;z): ");
int BX = Convert.ToInt32(Console.ReadLine());
int BY = Convert.ToInt32(Console.ReadLine());
int BZ = Convert.ToInt32(Console.ReadLine());

double squareX = Math.Pow(BX - AX, 2);              // возведение в степень
double squareY = Math.Pow(BY - AY, 2);
double squareZ = Math.Pow(BZ - AZ, 2);

double rootXYZ = Math.Sqrt(squareX + squareY + squareZ);       // корень квадратный

System.Console.WriteLine(Math.Round(rootXYZ, 2));    // округление
