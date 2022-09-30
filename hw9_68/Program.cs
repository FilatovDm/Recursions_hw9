/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int ank = 0;
int GetResultFuncAnkerman(int m, int n)
{
    if (m == 0) ank = n + 1;
    else if (m > 0 && n == 0) GetResultFuncAnkerman(m - 1, 1);
    else if (m > 0 && n > 0) GetResultFuncAnkerman(m-1, GetResultFuncAnkerman(m, n-1));
    return ank;
}

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int resultFuncAnkerman = GetResultFuncAnkerman(m, n);
Console.WriteLine("Результат вычисления функции Анкермана: " + resultFuncAnkerman);
