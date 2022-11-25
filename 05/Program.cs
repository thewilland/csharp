//С клавиатуры вводятся три числа. Найти максимальное из трех чисел

System.Console.WriteLine("enter first number: ");
int first_number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("enter second number: ");
int second_number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("enter third number: ");
int third_number = Convert.ToInt32(Console.ReadLine());

if (first_number > second_number && first_number > third_number) System.Console.WriteLine($"the biggest number is {first_number}");
if (first_number < second_number && second_number > third_number) System.Console.WriteLine($"the biggest number is {second_number}"); else System.Console.WriteLine($"the biggest number is {third_number}"); 
