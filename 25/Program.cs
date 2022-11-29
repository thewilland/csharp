// Вывести на экран кубы чисел от 1 до N

int Cube(int number)
{
    int number_cube = number * number * number;
    return number_cube;
}

System.Console.Write("enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());

int a;

for (a = 1; a <= N; a++)
{
    System.Console.Write($"{Cube(a)} ");
}

