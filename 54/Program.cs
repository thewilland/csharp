// 54 С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

System.Console.Write("enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] fibonacci_array()
{
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < N; i++)
        array[i] = array[i - 1] + array[i - 2];
    return array;
}

void print_array(int[] array, int tab = 5)
{
    string formatString="{0,"+tab+"}";
    for(int i = 0; i < array.Length; i++)
        System.Console.Write(formatString,array[i]);
}

int[] array = fibonacci_array();
print_array(array);
