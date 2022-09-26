/*Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, 
необходимо вывести максимальную цифру в полученном округлённом значении площади круга 
10->4 
20 ->7 
30 -> 8*/

Console.Write("Введите радиус окружности: ");
int r = Convert.ToInt32(Console.ReadLine());
double A = Math.PI * Math.Pow(r,2);
A = Math.Round(A, 0);
string numA = Convert.ToString(A);

int ind = 0; 
int max = numA[0];
int indMax = 0;
while (ind < numA.Length)
{        
    if (numA[ind] > max)
    {
        max = numA[ind];
        indMax = ind;
    }   
    ind++;    
}
Console.WriteLine(numA[indMax]);
