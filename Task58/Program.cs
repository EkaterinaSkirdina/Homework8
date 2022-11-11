/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

void Main()
{
    int[,] matrix1 = GetArray(2, 2);
    Console.WriteLine("Матрица 1");
    PrintArray(matrix1);

    int[,] matrix2 = GetArray(2, 2);
    Console.WriteLine("Матрица 2");
    PrintArray(matrix2);
    Console.WriteLine("Результирующая матрица: ");
    PrintArray(MatrixProduct(matrix1, matrix2));
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

int[,] MatrixProduct(int[,] arg1, int[,] arg2)
{
    int[,] result = new int[arg1.GetLength(0), arg2.GetLength(1)];
    if (arg1.GetLength(0) == arg2.GetLength(1))
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int n = 0; n < arg1.GetLength(0); n++)
                {
                    result[i, j] += arg1[i, n] * arg2[n, j];
                }
            }
        }
    }
    return result;
}

Main();