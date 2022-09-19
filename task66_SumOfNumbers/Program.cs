// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Please write amount M");
int amM=int.Parse(Console.ReadLine());

Console.WriteLine("Please write amount N");
int amN=int.Parse(Console.ReadLine());

double Numbers (int n)
{
    if (n==1) return 1;
    else return Numbers(n-1)+1;
}
int Sum=0;
for (int i = amM; i < amN+1; i++)
{
    Sum=Sum+i;
   
}
 Console.WriteLine($"{Sum}");