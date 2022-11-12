/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


void Main()
{
    int[,] array = new int[4, 4];
    int N = array.GetLength(0);
    int M = array.GetLength(1);

    GetArray(array, N, M);
    PrintArray(array);
}

int[,] GetArray(int[,] arg, int N, int M)
{
    int iBegin = 0;
    int iFinish = 0;
    int jBegin = 0;
    int jFinish = 0;

    int k = 01;
    int i = 0;
    int j = 0;

    while (k <= N * M)
    {
        arg[i, j] = k;
        if (i == iBegin && j < M - jFinish - 1)
            j++;
        else if (j == M - jFinish - 1 && i < N - iFinish - 1)
            i++;
        else if (i == N - iFinish - 1 && j > jBegin)
            j--;
        else
            i--;

        if ((i == iBegin + 1) && (j == jBegin) && (jBegin != M - jFinish - 1))
        {
            iBegin++;
            iFinish++;
            jBegin++;
            jFinish++;
        }
        k++;
    }
    return arg;
}

void PrintArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
            if (arg[i, j] < 10)
            {
                Console.Write($"0{arg[i, j]} ");
            }
            else
            {
                Console.Write($"{arg[i, j]} ");
            }
        Console.WriteLine();
    }
}

Main();

