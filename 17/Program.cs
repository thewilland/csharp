// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.Write("enter the week day's number: ");
int daynumber = Convert.ToInt32(Console.ReadLine());
if (daynumber < 8 && daynumber > 0) 
{
    if (daynumber > 5) System.Console.WriteLine("today is a weekend!");
    else System.Console.WriteLine("today is not a weekend :(");
}
else System.Console.WriteLine("invalid number!");
