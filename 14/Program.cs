// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

System.Console.Write("enter number a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("enter number b: ");
int b = Convert.ToInt32(Console.ReadLine());

int r = a % b;

if (a % b == 0) System.Console.WriteLine($"number {a} is a multiple of number {b}!");
else System.Console.WriteLine($"the remainder of {a} divided by {b} is {r}!");
