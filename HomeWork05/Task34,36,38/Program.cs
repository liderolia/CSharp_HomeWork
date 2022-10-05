void FillArray(int[] num, int min, int max) 
{
    int size = num.Length;
    Random array = new Random();
    for(int i=0; i< size; i++)
    {
        num[i] = array.Next(min, max);         
    }
}

void PrintArray(int[] num)
{
    int size = num.Length;
    for(int i=0; i< size; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.WriteLine();
}


void Task34()
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
{                
    int size = 5;
    int[] num = new int[size];
    FillArray(num, 100, 1000);
    PrintArray(num);
    int count = 0;

    for(int i=0; i< size; i++)
    {        
        if(num[i]%2 == 0)
        count++;           
    }  
    Console.WriteLine("количество чётных чисел в массиве: " +count);
}

void Task36()
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
{                
    int size = 5;
    int[] num = new int[size];
    FillArray(num, -10, 10);
    PrintArray(num);
    int sum = 0;
    for(int i=1; i<size; i+=2) 
    /*рассматриваю нечетные позиции относительно значения индекса (i==1, 3 и т.д.),
    Если решать задачу отнсительно эллемента в массиве (1-е число, 3-е и т.д.), 
    то в цикле for присваеваем значение индекса =0: for(int i=0; i<size; i+=2)*/
    {
        sum += num[i];              
    }    
    Console.WriteLine("сумма элементов, стоящих на нечётных позициях = " +sum);
}

void Task38()
/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
{
    int size = 10;
    double[] num = new double[size];
    Random Array = new Random();
    for(int i=0; i< num.Length; i++)
    {
        num[i] = Math.Round((Array.NextDouble()*20 -10), 1); 
        Console.Write(num[i]+"  ");        
    }
    Console.WriteLine();    
    double min = num[0];
    double max = num[0];
    double diff = 0;
    for(int ind=0; ind<num.Length; ind++)
    {
        if (num[ind] > max)
        {            
            max = num[ind];
        }
        if (num[ind] < min)
        {            
            min = num[ind];
        }
        diff = max - min;       
    }
    Console.WriteLine("максимальное значение массива: " +max);
    Console.WriteLine("мминимальное значение массива: " +min);
    Console.WriteLine("разница между максимальным и минимальным элементов массива = " +Math.Round((diff), 1));        
}


Task38();