//С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго (блок-схема)

System.Console.WriteLine("enter number a:");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("enter number b:");
double b = Convert.ToDouble(Console.ReadLine());

if (a * a == b) System.Console.WriteLine($"{b} is a square of {a}");
if (b * b == a) System.Console.WriteLine($"{a} is a square of {b}");
