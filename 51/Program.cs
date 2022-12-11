// 52 С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

System.Console.Write("enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array()
{
    System.Console.WriteLine($"enter {N} numbers: ");
    int[] numbers = new int[N];
    for(int i = 0; i < N; i++)
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    return numbers;
}

int count_positive(int[] numbers)
{
    int counter = 0;
    for(int i = 0; i < N; i++)
        if (numbers[i] > 0) counter++;
    return counter;
}

int[] numbers = array();
System.Console.WriteLine($"the amount of numbers higher than 0 is: {count_positive(numbers)}");
