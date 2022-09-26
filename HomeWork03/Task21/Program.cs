/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.*/

Console.WriteLine("Введите координаты точки A");
Console.Write("x = ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("x = ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int Bz = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow(Ax-Bx,2) + Math.Pow(Ay-By,2) + Math.Pow(Az-Bz,2));
Console.WriteLine($"расстояние между точками А и В = {Math.Round(S, 2)}");