// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

// double Factorial (int n)
// {
//     if (n==1) return 1;
//     else return n*Factorial(n-1);
// }
// for (int i=1; i<40; i++)
// {
//     Console.WriteLine($"{i}!={Factorial(i)}");
// }

Console.WriteLine("Please write amount M");
int amM=int.Parse(Console.ReadLine());

Console.WriteLine("Please write amount N");
int amN=int.Parse(Console.ReadLine());

double Numbers (int n)
{
    if (n==1) return 1;
    else return Numbers(n-1)+1;
}

for (int i = amM; i < amN+1; i++)
{
    Console.WriteLine($"{Numbers(i)}");
}

