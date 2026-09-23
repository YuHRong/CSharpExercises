using FibonacciGenerator;

var fibs = new FibonacciGenerate();
foreach (var fib in fibs.Generate(20))
{
 Console.WriteLine(fib);
}