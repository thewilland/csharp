// Определить, присутствует ли в заданном массиве, некоторое число

int[] RandomIntArray(int N,int min,int max)
{
    int[] a=new int[N];
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

void PrintArray(int[] a,int tab=5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
        System.Console.Write(formatString,a[i]);
}
int BinSearch(int[] a,int find)
{
    int i;
    int left=0;
    int right=a.Length-1;
    i=left+(right-left)/2;
    while(a[i]!=find && left<right)
    {
          if (find>a[i])  
              left=i+1;
          else
            right=i;
        i=left+(right-left)/2;
    }
    if (a[i]!=find)
        return -1;
    else
        return i;
}

System.Console.Write("enter the number you want to find: ");
int find = Convert.ToInt32(Console.ReadLine());

{
    int[] a=RandomIntArray(10,15,25);
    Array.Sort(a);
    PrintArray(a);
    System.Console.WriteLine("\n"+BinSearch(a,find));
}
