// Подсчитать сумму цифр в числе. Сделать подпрограмму.

int Count(int number)
{
    int count = 0;
    if (number == 0) count = 1;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}


int Sum(int number1, int number2)
{
    int number_sum = number1 + number2;
    return number_sum;
}

System.Console.Write("enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = Count(number);
int a;
int sum = 0;
for (a = 0; a < count; a ++)
{
    int number1 = number % 10;
    number = number / 10;
    
    sum = Sum(number1, sum);
}

System.Console.WriteLine(sum);
