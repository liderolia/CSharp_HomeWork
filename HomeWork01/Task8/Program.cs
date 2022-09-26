// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

if(N >= 0)
{
    int count = 2;
    while(count <= N)
    {
        if(count%2 == 0)
        {
            Console.WriteLine(count);
            count += 2;
        }                
    } 
}
if(N == 0)
{
    Console.WriteLine(N); 
}
else
{
    int count = -2;
    while(count >= N)
    {
        if(count%2 == 0)
        {
            Console.WriteLine(count);
            count -= 2;
        }                
    } 
}
