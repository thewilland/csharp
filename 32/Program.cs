﻿// Задать массив из 8 целых элементов и вывести их на экран

int[] NewArray(int size,int min, int max)
{
    int[] a = new int[size];
    Random random = new Random();
    for(int i = 0; i < size; i ++)
        a[i] = random.Next(min, max + 1);
    return a;
}

void Print(int[] a)
{
    for(int i = 0; i < a.Length; i ++)
        System.Console.Write($"{a[i],5}");
}

int[] a = NewArray(8, 0, 100);
Print(a);
