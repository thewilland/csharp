﻿//60 Показать двумерный массив размером m×n заполненный целыми случайными числами

int[,] Create2DArray(int n,int m, int min, int max)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for(int i = 0; i < n; i++)
         for(int j = 0; j < m; j++)
                a[i, j] = random.Next(min, max + 1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i = 0;i < a.GetLength(0); i++)
        {
     for(int j = 0; j < a.GetLength(1); j++)
        System.Console.Write($"{a[i, j],4}");
           System.Console.WriteLine();
        }
}

int[,] a = Create2DArray(4, 4, 0, 100);
Print2DArray(a);
