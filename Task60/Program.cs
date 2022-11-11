/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


void Main()
{
    int[,,] array = GetArray(2, 2, 2);
    PrintArray(array);
}

int[,,] GetArray(int l, int m, int n)
{
    int[,,] result = new int[l, m, n];
    int number = 10;
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int z = 0; z < n; z++)
            {
                result[i, j, z] = number;
                number++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            for (int z = 0; z < arg.GetLength(2); z++)
            {
                Console.Write($"{arg[i, j, z]}({i},{j},{z}) ");
            }
        }
        Console.WriteLine();
    }
}

Main();
