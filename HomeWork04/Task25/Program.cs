/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите натуральное число B: ");
int B = Convert.ToInt32(Console.ReadLine()); 

if (B < 0)
{
    Console.WriteLine("не корректный ввод");
}
else
{
    Console.WriteLine($"{A}^{B} = {Math.Pow(A, B)}");
}


// Console.Clear();
// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите натуральное число B: ");
// int B = Convert.ToInt32(Console.ReadLine()); 
// if (B < 0)
// {
//     Console.WriteLine("не корректный ввод");
// }
// else
// {
//     int a = A;
//     int b = B; //ввела переменную для корректного отображения вывода
//     while( B > 1)
//     {
//        A = A*a;
//        B--;          
//     } 
//     Console.WriteLine($"{a}^{b} = {A}");      
// }

