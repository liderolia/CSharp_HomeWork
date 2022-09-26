// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int i = Convert.ToInt32(Console.ReadLine());
int Number2 = 0;

if (i<0)
{
    i=-i;
}
if (i<100 | i>1000)
{
   Console.WriteLine("Не корректный ввод числа");
}

else
{
    Number2 = i/10%10;
    Console.WriteLine($"Вторая цифра: {Number2}");
}