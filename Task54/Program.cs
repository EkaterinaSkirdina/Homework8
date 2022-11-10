/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

void Main()
{
    int[,] array = GetArray(3,4);
    PrintArray(array);
    Console.WriteLine();
    SortArray(array);
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

void SortArray( int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(1)-1; z++)
            {
                if(arr[i,z] < arr[i,z+1])
                {
                    int temp = 0;
                    temp = arr[i,z];
                    arr[i,z] =arr[i,z+1];
                    arr[i,z+1] = temp;
                }
            }
        }
    }
    PrintArray(arr);
}

Main();