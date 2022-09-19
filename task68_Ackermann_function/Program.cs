// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Please write amount M");
int amM=int.Parse(Console.ReadLine());

Console.WriteLine("Please write amount N");
int amN=int.Parse(Console.ReadLine());

double Ackermann (double m, double n)
{
    if (m==0) return n+1;
    if (m>0 && n==0) return Ackermann(m-1,1);
    if (m>0 && n>0)  return Ackermann(m-1,Ackermann(m,n-1));
    else return 0;
}

double result=0;

for (int i = 0; i < amN+1; i++)
{
    for (int j = 0; j < amN; j++)
    {
        // Console.WriteLine($"{Ackermann(i,j)}");
        result=Ackermann(i,j);
    }
   
}
Console.WriteLine($"Ackermann ({amM},{amN}) result is {result}"); 