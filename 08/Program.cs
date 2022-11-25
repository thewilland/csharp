// Вывести на экран числа от -N до N

// используя цикл while
/*
System.Console.WriteLine("enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int counter = 0;
int a = -N;
while (counter < N * 2 + 1){
    System.Console.Write($"{a} ");
    a++;
    counter ++;
}
*/

// используя цикл for

System.Console.WriteLine("enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = -N; i <= N; i++){
    Console.Write(i);
}

