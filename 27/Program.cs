// Возведите число А в натуральную степень B используя цикл

int Power(int start_number, int power)
{
    int a = 1;
    int number = start_number;
    while (a < power)
    {
        number = number * start_number;
        a ++;
    }
    return number;
}


System.Console.WriteLine("enter number: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("enter power: ");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Power(A, B));
