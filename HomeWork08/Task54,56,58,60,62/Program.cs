void FillArrayTwo(int[,] num, int min, int max)  
{
    Random array = new Random();
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i, j] = array.Next(min, max);
        }
    }
}
void PrintArrayTwo(int[,] num) 
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            Console.Write(num[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int InputRandom()
{
    Random random = new Random();
    return random.Next(2, 4); //сильно ограничила массив для удобства решения 58 задачи
}

void Task54()
/*Задача 54: {
    Задайте двумерный массив. Напишите программу, 
    которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    7 4 2 1
    9 5 3 2
    8 4 4 2
}*/
{
    Console.Clear();    
    int Row = InputRandom();
    int Column = InputRandom();
    int[,] TwoArray = new int[Row, Column];
    FillArrayTwo(TwoArray, 0, 10);
    PrintArrayTwo(TwoArray);
    Console.WriteLine("Массив по убыванию: ");
    for (int i = 0; i < Row; i++)
        for (int j = 0; j < Column; j++)            
            for (int k = 0; k < Column; k++)
                {
                    if (TwoArray[i, j] >= TwoArray[i, k])
                    {
                        int temp = TwoArray[i, j];
                        TwoArray[i, j] = TwoArray[i, k];
                        TwoArray[i, k] = temp;
                    }
                }
    PrintArrayTwo(TwoArray);              
}
//Task54();


void Task56()
/*Задача 56: {
    Задайте прямоугольный двумерный массив. Напишите программу, 
    которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке 
    и выдаёт номер строки с наименьшей суммой элементов: 1 строка
}*/
{
    Console.Clear();    
    int Row = InputRandom();
    int Column = InputRandom();
    if (Row > Column | Row < Column)
    {              
        int[,] TwoArray = new int[Row, Column];
        FillArrayTwo(TwoArray, 0, 10);
        PrintArrayTwo(TwoArray);        
        int sumRow = int.MaxValue;
        int indMin = 0;
        for (int i = 0; i < Row; i++)
        {   
            int sum = 0;
            for (int j = 0; j < Column; j++)
            {  
                sum += TwoArray[i, j];                              
            }            
            if (sum < sumRow)
            {
                sumRow = sum;
                indMin = i;                    
            }
            Console.WriteLine($"сумма элементов {i+1} строки = {sum}");            
        }
        Console.WriteLine();       
        Console.WriteLine($"Наименьшая сумма элементов = {sumRow}, находится в {indMin + 1} строке.");
    }
    else  Console.WriteLine("Массив не прямоугольный");    
}
//Task56();

void Task58()
/*Задача 58: {
    Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
}*/
{
    Console.Clear();
    int m = InputRandom();
    int n = InputRandom();
    int o = InputRandom();    
    int[,] OneArray = new int[m, n];
    int[,] TwoArray = new int[n, o];
    FillArrayTwo(OneArray, 1, 4);
    FillArrayTwo(TwoArray, 1, 4);
    PrintArrayTwo(OneArray);
    Console.WriteLine();
    PrintArrayTwo(TwoArray);
    int[,] Result = new int[m, o];    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < o; j++)
        {
            int sum = 0;
            for (int k = 0; k < n; k++)
            {
                sum += OneArray[i, k] * TwoArray[k, j];
            }
            Result[i, j] = sum;
        }
    }
    Console.WriteLine("Произведение двух матриц: ");
    PrintArrayTwo(Result);
}
//Task58();


void Task60()
/*Задача 60. {
    Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
    которая будет построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2
    66(0,0,0) 25(0,1,0)
    34(1,0,0) 41(1,1,0)
    27(0,0,1) 90(0,1,1)
    26(1,0,1) 55(1,1,1)
}*/
{
    Console.Clear();
    int m = InputRandom();
    int n = InputRandom();
    int o = InputRandom();
    Console.WriteLine($"");
    int[,,] Array3D = new int[m, n, o];
    FillArray3d(Array3D, 1, 10);
    PrintArray3d(Array3D);

    void FillArray3d(int[,,] num, int min, int max)  
    {
        Random array = new Random();
        for (int i = 0; i < num.GetLength(0); i++)    
            for (int j = 0; j < num.GetLength(1); j++)
                for (int k = 0; k < num.GetLength(2); k++)
                {
                    num[i, j, k] = array.Next(min, max);
                }    
    }
    void PrintArray3d(int[,,] Array3D)
    {
        for (int i = 0; i < Array3D.GetLength(0); i++)
        {
            for (int j = 0; j < Array3D.GetLength(1); j++)
            {            
                for (int k = 0; k < Array3D.GetLength(2); k++)
                {
                    Console.Write($"{Array3D[i, j, k]} ({i} {j} {k})"+ "\t");
                }
            Console.WriteLine();
            }
            Console.WriteLine();
        }
    }    
}
//Task60();


void Task62()
/*Задача 62. {
    Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07
}*/
{
    Console.Clear();    
    int n = 4; /*можно задавать любое значение массива до 9 включительно. Если 10 и более, то надо доработать код, 
            т.к. появляются 3-хзначные и более числа (не проверяла свыше 3-хзначных) и выравнивание слетает, либо делать отступ через "\t" */
    int[,] TwoArray = new int[n, n];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= n * n)
    {
        TwoArray[i, j] = temp;
        temp++;
        if (i <= j + 1 & i + j < n - 1) j++;
        else if (i < j & i + j >= n - 1) i++;
        else if (i >= j & i + j > n - 1) j--;
        else i--;
    }
    PrintArray(TwoArray);
    void PrintArray (int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] / 10 <= 0)
                Console.Write($"0{array[i,j]} ");

                else Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }    
}
//Task62();
