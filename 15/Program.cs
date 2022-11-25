// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

System.Console.Write("enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int t = number / 100 % 10;

if (number < 100) System.Console.WriteLine("NO :(");
else System.Console.WriteLine(t);
