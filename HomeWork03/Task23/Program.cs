/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.*/

Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()); 
for(int count = 1; count <= N; count++) 
{
    double cubic = Math.Pow(count,3);
    Console.WriteLine(cubic);
}

