// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else if (num2 == 0 && num1 > 0)
    {
        return AkkermanFunction(num1 - 1, 1);
    }
    else
    {
        return AkkermanFunction(num1 - 1, AkkermanFunction(num1, num2 - 1));
    }
}

Console.WriteLine("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkermanFunction = AkkermanFunction(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {akkermanFunction} ");
    