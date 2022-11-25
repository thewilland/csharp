// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

System.Console.Write("enter X: ");
double x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("enter Y: ");
double y = Convert.ToInt32(Console.ReadLine());

static int QuarterNumber(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
int q = QuarterNumber(x,y);
System.Console.WriteLine($"the quarter number is: {q}");
