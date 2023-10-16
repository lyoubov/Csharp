/* Напишите программу, которая 
принимает на вход координаты двух точек и 
находит расстояние между ними в 
2D пространстве 

A(3,6); B(2,1)  ->  5,09
A(7,-5); B(1,-1)  ->  7,21*/

System.Console.WriteLine("Введите для точки А (х;у): ");
int AX = Convert.ToInt32(Console.ReadLine());
int AY = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите для точки В (х;у): ");
int BX = Convert.ToInt32(Console.ReadLine());
int BY = Convert.ToInt32(Console.ReadLine());

double squareX = Math.Pow(BX - AX, 2);              // возведение в степень
double squareY = Math.Pow(BY - AY, 2);

double rootXY = Math.Sqrt(squareX + squareY);       // корень квадратный

System.Console.WriteLine(Math.Round(rootXY, 2));    // округление