// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Clear();
// Console.Write("Введите число: ");
// int i = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int tmp = 100;
// int tmp2 = tmp*10;

// if (i<0)
// {
//     i=-i;
// }
// int Number3 = i/count%10;
// if (i < 100)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// while ( i > tmp)
// {
//     if (i < tmp2)
//     {
//         Number3 = i/count%10;
//         Console.WriteLine(Number3);
//     }
//     tmp2 = tmp2*10;
//     tmp = tmp*10; 
//     count = count*10; 
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int i = Convert.ToInt32(Console.ReadLine());
// int Number3 = 0;
// if (i<0)
// {
//     i=-i;
// }
// int tmp = i;
// if (i < 100)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else
// {
//     while (i > 1000)
//     {
//         i = i/10;
//         tmp = i;    
//     }
//     Number3 = tmp%10;
//     Console.WriteLine(Number3);
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int i = Convert.ToInt32(Console.ReadLine());
// int Number3 = 0;
// if (i<0)
// {
//     i=-i;
// }
// if (i < 100)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else
// {
//     while (i > 1000)
//     {
//         i = i/10;         
//     }
//     Number3 = i%10;
//     Console.WriteLine(Number3);
// }


//using System;
Console.Write("Введите число: ");
double i = Convert.ToInt64(Console.ReadLine());
double reg = 0;
double res = 0;
i = Math.Abs(i);
if (i < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    reg=(Math.Log10(i)-Math.Log10(i)%1)-1;
    res=(i % Math.Pow(10,reg)/Math.Pow(10,reg-1)) - (i % Math.Pow(10,reg)/Math.Pow(10,reg-1))%1;
    Console.WriteLine(res);
}

