int InputRandom(int i, int j)
{
    Random rnd = new Random();
    return rnd.Next(i, j);    
}

void Task64()
/*Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
{
    Console.Clear();
    int N = InputRandom(2, 10);
    Console.WriteLine(N);
    Console.WriteLine("все натуральные числа от " +N +" до 1:");
    int a = N+1; 
    FindNatural();   
    void FindNatural()
    {
        a--;
        Console.WriteLine(a);      
        if(a <= 1)
        { 
            return; 
        }        
        FindNatural();
    }
}
//Task64();

void Task66()
/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
{
    Console.Clear();
    int M = InputRandom(1, 5);
    int N = InputRandom(5, 10);
    Console.WriteLine(M);
    Console.WriteLine(N);    
    int temp = M; //если менять условия ввода значения М и N на ручной или без ограничения рандома, что M < N
    int tmp = M; //для итогового вывода исходного значения M
    if (M > N) 
    {
        M = N; 
        N = temp;
    }
    int sum = 0;    
    PrintSum();   
    void PrintSum()
    {
        sum=sum+M;
        M++;             
        if(M > N)
        { 
            Console.Write($"Сумма натуральных элементов в промежутке от {tmp} до {N} = {sum}"); 
            return; 
        }        
        PrintSum();
    }

}
//Task66();

void Task68()
/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
{
    Console.Clear();
    int m = InputRandom(0, 4);
    int n = InputRandom(0, 4);
    Console.WriteLine(m);
    Console.WriteLine(n);
    int Akkerman = A(m,n);
    Console.Write($"Функция Аккермана = {Akkerman}");
    int A(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return A(m - 1, 1);
        else return A(m - 1, A(m, n - 1));
    }
}
Task68();