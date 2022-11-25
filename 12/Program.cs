// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

System.Console.Write("enter a number from 10 to 99: ");
int number = Convert.ToInt32(Console.ReadLine());
int first_digit = number % 10;
int second_digit = number / 10 % 10;
if (first_digit > second_digit) System.Console.Write($"the biggest digit is: {first_digit}");
else System.Console.Write($"the biggest digit is: {second_digit}");
