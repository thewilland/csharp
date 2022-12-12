//64 В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

int[,] Create2DArray(int n,int k, int min, int max)
{
    int[,] a = new int[n, k];
    Random random = new Random();
    for(int i = 0; i < n; i++)
         for(int j = 0; j < k; j++)
                a[i, j] = random.Next(min, max + 1);
    return a;
}

int[,] Convert2DArraysSquareEvenSomethingIDK(int[,] a, int n, int k)
{
    for(int i = 0; i < n; i++)
         for(int j = 0; j < k; j++)
         if (i % 2 == 0 && j % 2 == 0) a [i, j] = a[i, j] * a[i, j];
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
int[,] converted = Convert2DArraysSquareEvenSomethingIDK(a, 4, 4);
Print2DArray(a);
