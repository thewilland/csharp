// Программа проверяет пятизначное число на палиндромом.

System.Console.Write("enter a five digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int first_half = number / 1000;
int second_half = number % 100;
int a = second_half / 10;
int b = second_half % 10;
int second_half_reversed = Convert.ToInt32(string.Format("{0}{1}", b, a));

if (first_half == second_half_reversed) System.Console.WriteLine("it's a palindrome!");
else System.Console.WriteLine("it's not a palindrome");
