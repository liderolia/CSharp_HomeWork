/* Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, 
является ли этот день выходным.*/

Console.Write("Введите цифру дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day<1 | day>7)
{
   Console.WriteLine("Не корректный ввод");
}
else 
{   if (day<6)
    {
        Console.WriteLine("Будний день");
    }
    else 
    {
        Console.WriteLine("Выходной день");
    }
}