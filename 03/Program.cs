// С клавиатуры вводятся два числа a и b. Найти максимальное из них.

System.Console.WriteLine("enter a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("enter b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) System.Console.WriteLine($"the biggest number is a"); else System.Console.WriteLine($"the biggest number is b");
