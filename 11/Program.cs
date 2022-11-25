//11. Дано число больше 9. Вывести на экран  вторую цифру числа с конца

System.Console.Write("enter a number that is higher than 9: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(a / 10 % 10);
