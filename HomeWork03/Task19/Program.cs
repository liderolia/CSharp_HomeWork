/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.*/

// // решение задачи математически:
Console.Write("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N<10000 | N>100000)
{
    Console.WriteLine("некорректный ввод");
}
else
{
    int count5 = N % 10;
    N = N/10;
    int count4 = N % 10;
    N = N/100;
    int count2 = N % 10;
    N = N/10;
    int count1 = N % 10;
    
    if (count5 == count1 & count4 == count2 )
    {
       Console.WriteLine("число является палиндромом"); 
    }
    else
    {
        Console.WriteLine("число не является палиндромом");
    }    
}


// // решение задачи строкой:
// Console.Write("Введите пятизначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// string numberstr = Convert.ToString(N);
// if (N<10000 | N>100000)
// {
//     Console.WriteLine("некорректный ввод");
// }
// else 
// {    
//     if (numberstr[4] == numberstr[0] & numberstr[3] == numberstr[1])
//     {
//         Console.WriteLine("число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("число не является палиндромом");
//     }
// }



