void Task41()
/*Задача 41:  Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
{    
    Console.Write("Введите нужное количество чисел через пробел: ");
    int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int size = num.Length;
    int count = 0;
    for(int i=0; i< size; i++)
    {        
        if(num[i] > 0)
        count++;           
    }  
    Console.WriteLine("количество положительных чисел: " +count);    
}


void Task43()
/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
{       
    Console.Write("Введите значение b1 = ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение k1 = ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение b2 = ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение k2 = ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * x + b1, 2);
    Console.WriteLine($"Пересечение в точке: ({x}; {y})");            
}
Task41();

