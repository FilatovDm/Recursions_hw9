/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        int sum = m;

        if (m != n)
        {
            sum = sum + GetNaturalNumbers(m + 1, n);
        }
        
    }
    else if (m >= n)
    {
        int sum = n;

        if (n < m)
        {
            sum = sum + GetNaturalNumbers(m, n + 1);
        }
        
    }
    return sum;
}

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sumElem = GetNaturalNumbers(m, n);
System.Console.WriteLine($"Сумма элементов от {m} до {n}: {sumElem}");
