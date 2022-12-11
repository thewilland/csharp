// 56 Написать программу копирования массива

int[] array(int size,int min, int max)
{
    int[] a = new int[size];
    Random random = new Random();
    for(int i = 0; i < size; i ++)
        a[i] = random.Next(min, max + 1);
    return a;
}

int[] copy_array(int[] a)
{
    int[] copy = new int[a.Length];
    for(int i = 0; i < a.Length; i ++)
        copy[i] = a[i];
    return copy;
}

void Print(int[] a)
{
    for(int i = 0; i < a.Length; i ++)
        System.Console.Write($"{a[i],5}");
}

int[] a = array(8, 0, 100);
int[] copy = copy_array(a);
Print(a);
System.Console.WriteLine();
Print(copy);
