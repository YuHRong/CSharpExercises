
Console.WriteLine("前 20 个斐波那契数列是： ");
for (int i = 0; i < 20; i++)
{
 Console.WriteLine($"{i + 1} : {Fibonacci(i)}");
}

static int Fibonacci(int n)
{
 int a = 0;
 int b = 1;
 int temp;

 for (int i = 0; i < n; i++)
 {
  temp = a;
  a = b;
  b += temp;
 }

 return a;
}