// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

System.Console.Write("eneter array's size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] RandomIntArray(int size,int min,int max)
{
    int[] a = new int[size];
    Random random = new Random();
    for(int i = 0;i < a.Length;i++)
        a[i] = random.Next(min, max + 1);
    return a;
}

void PrintArray(int[] a, int tab = 5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
        System.Console.Write(formatString,a[i]);
}

int CountEven(int[] a)
{
    int count_e = 0;
    for(int i = 0;i < a.Length;i++)
        if (a[i] % 2 == 0)
            count_e++;

    return count_e;
}

int CountOdd(int[] a)
{
    int count_o = 0;
    for(int i = 0;i < a.Length;i++)
        if (a[i] % 2 != 0)
            count_o++;

    return count_o;
}

int[] a = RandomIntArray(size,100,1000);
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine($"the amount of even numbers is: {CountEven(a)}");
System.Console.WriteLine($"the amount of odd numbers is: {CountOdd(a)}");
