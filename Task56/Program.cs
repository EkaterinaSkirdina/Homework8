/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

void Main()
{
    int[,] array = GetArray(3, 4);
    PrintArray(array);
    Console.WriteLine();
    int minSumRow = 0;
    int sumRowEl = FindSumRowElements(array, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempSumRowEl = FindSumRowElements(array, i);
        if (sumRowEl > tempSumRowEl)
        {
            sumRowEl = tempSumRowEl;
            minSumRow = i;
        }
    }
    Console.WriteLine($"Строка с индексом {minSumRow} имеет наименьшую сумму элементов {sumRowEl}.");
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindSumRowElements(int[,] arr, int i)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[i, j];
    }
    return sum;
}

Main();