// Написать программу замены элементов массива на противоположные

// я надеюсь что я правильно задачу понял

System.Console.Write("eneter array's size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] RandomIntArray(int size, int min = 0, int max = 100)
{
    int[] a = new int[size];
    Random random = new Random();
    for(int i = 0;i<size;i++)
        a[i] = random.Next(min, max + 1);
    return a;
}

void Swap(ref int a, ref int b)
{
    int c;
    c = a;
    a = b;
    b = c;

}

int[] SwapArray( int[] a, int size)
{
    for(int i = 0; i < size / 2; i++)
    {
        Swap(ref a[i], ref a[size - 1 - i]);
    }

    return a;     
}

void Print(int[] a)
{
    for(int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],5}");
        System.Console.WriteLine();
}


int[] a = RandomIntArray(size, 0, 100);
Print(a);
SwapArray(a, size);
Print(a);
