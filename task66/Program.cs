// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void SumNaturalNumbers(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
        return;
    }
    SumNaturalNumbers(m, n - 1, sum);
}
Console.WriteLine("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());

int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
Console.Write($"Cуммa натуральных элементов в промежутке от {m} до {n} ->");
SumNaturalNumbers(m, n, temp = 0);