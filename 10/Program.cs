// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

System.Console.Write("enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"the last digit of that number is: {number % 10}");
