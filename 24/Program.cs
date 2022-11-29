//Вывести на экран таблицу квадратов чисел от 1 до N

int Square(int number)
{
    int number_square = number * number;
    return number_square;
}

System.Console.Write("enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());

int a;

for (a = 1; a <= N; a++)
{
    System.Console.Write($"{Square(a)} ");
}

