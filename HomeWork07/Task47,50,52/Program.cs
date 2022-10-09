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

void FillArrayTwoDouble(double[,] num)  
{
    Random random = new Random();
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i, j] = random.NextDouble() * 200 - 100;
            num[i, j] = Math.Round(num[i, j], 1);
        }
    }
}

void PrintArrayTwoDouble(double[,] num)  
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
    return random.Next(3, 6); //ограничиваю размер двумерного массива 
}

int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void Task47()
/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
{
    Console.Clear();
    int m = InputMessage("Введите колличество строк: ");
    int n = InputMessage("Введите колличество столбцов: ");
    double[,] TwoArray = new double[m, n];
    FillArrayTwoDouble(TwoArray);
    PrintArrayTwoDouble(TwoArray);
}
//Task47();

void Task50()
/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
{
    Console.Clear();    
    int m = InputRandom();
    int n = InputRandom();
    int[,] TwoArray = new int[m, n];
    FillArrayTwo(TwoArray, 0, 100);
    PrintArrayTwo(TwoArray);
    int positionRow = InputMessage("Введите номер строки: ") -1; //т.к. индекс начинается с 0, то отнимаю 1
    int positionColumn = InputMessage("Введите номер столбца: ") -1;
    if (positionRow < TwoArray.GetLength(0) & positionColumn < TwoArray.GetLength(1))
    {
        Console.WriteLine($"Значение элемента = {TwoArray[positionRow, positionColumn]}");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует!");
    }
}
//Task50();

void Task52()
/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
{
    Console.Clear();    
    int m = InputRandom();
    int n = InputRandom();
    int[,] TwoArray = new int[m, n];
    FillArrayTwo(TwoArray, 0, 10);
    PrintArrayTwo(TwoArray);
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    for (int i=0; i<TwoArray.GetLength(1); i++)
    {
        double sum = 0;
        double average = 0;
        for (int j = 0; j < n; j++)
        {
            sum += TwoArray[j, i];            
        }
        average = Math.Round(sum / m, 1);        
        Console.Write(average + "\t");      
    }
    
}
//Task52();