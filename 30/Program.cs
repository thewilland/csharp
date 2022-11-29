// Написать программу вычисления произведения чисел от 1 до N

int Multiply(int number1, int number2)
{
    int number_mult = number1 * number2;
    return number_mult;
}

System.Console.Write("enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());

int a;
int mult = 1;

for (a = 1; a <= N; a++)
{
    mult = Multiply(a, mult);
}

System.Console.WriteLine(mult);
