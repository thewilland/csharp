//13. Удалить вторую цифру целого числа введенного с клавиатуры.

System.Console.Write("enter a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 100 * 10 + a % 10;
System.Console.WriteLine(b);
