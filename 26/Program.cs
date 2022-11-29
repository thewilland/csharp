// Найти сумму чисел от 1 до А

int Sum(int number1, int number2)
{
    int number_sum = number1 + number2;
    return number_sum;
}

System.Console.Write("enter a number: ");
int A = Convert.ToInt32(Console.ReadLine());

int sum = 1;
int b;

for (b = 2; b != A; b ++)
{
    sum = Sum(sum, sum + 1);
   
    System.Console.WriteLine(sum);
}

System.Console.WriteLine(sum);
