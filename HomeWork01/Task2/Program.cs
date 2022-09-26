// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите число ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число ");
int numB = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if(numA > numB)
{
    max = numA;
    min = numB;        
}
else
{
    max = numB;
    min = numA;   
}
Console.WriteLine($"{max} > {min}");
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");