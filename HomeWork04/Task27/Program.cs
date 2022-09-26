/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()); 
int sum = 0;
if (N<10)
{
    sum = N;
}
else
{
    while (N > 10)
    {
        int tmp = N%10;
        sum = sum + tmp;
        N = N/10;
    }   
    sum =  sum + N;
}
Console.WriteLine($"сумма цифр = {sum}");

