// По заданному с клавиатуры номеру дня недели вывести его название

System.Console.WriteLine("enter today's day number: ");
int day_number = Convert.ToInt32(Console.ReadLine());

if (day_number == 1) System.Console.WriteLine("today is monday!");
if (day_number == 2) System.Console.WriteLine("today is tuesday!");
if (day_number == 3) System.Console.WriteLine("today is wednesday!");
if (day_number == 4) System.Console.WriteLine("today is thursday!");
if (day_number == 5) System.Console.WriteLine("today is friday!");
if (day_number == 6) System.Console.WriteLine("today is saturday!");
if (day_number == 7) System.Console.WriteLine("today is sunday!");
else System.Console.WriteLine("oh i think you entered a wrong number :/");
