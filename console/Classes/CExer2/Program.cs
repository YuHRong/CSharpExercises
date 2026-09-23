using CExer2;

Operator oper = new Operator();

while (true)
{
 Console.WriteLine("请输入运算符（ +, -, *, /），输入 0 退出");
 char op = Convert.ToChar(Console.ReadLine());

 if (op == '0')
  break;

 Console.WriteLine("你是要进行三个数还是两个数的计算");
 int count = Convert.ToInt32(Console.ReadLine());
 double n1, n2, n3 = 0;
 double result = 0;

 try
 {
  if (count == 2)
  {
   Console.WriteLine("请输入第一个数");
   n1 = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("请输入第二个数");
   n2 = Convert.ToDouble(Console.ReadLine());
   result = oper.Num2Count(op, n1, n2);
   Console.WriteLine($"{n1} {op} {n2} = {result}");
  }
  else if (count == 3)
  {
   Console.WriteLine("请输入第一个数");
   n1 = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("请输入第二个数");
   n2 = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("请输入第三个数字");
   n3 = Convert.ToDouble(Console.ReadLine());
   result = oper.Num3Count(op, n1, n2, n3);
   Console.WriteLine($"{n1} {op} {n2} {op} {n3} = {result}");
  }
  else
  {
   Console.WriteLine("请输入（2 或 3");
   continue;
  }
 }
 catch (ArgumentException ex)    // 抛出运算符无效或者被除数为 0 的异常
 {
  Console.WriteLine($"操作错误: {ex.Message}");
  Console.WriteLine();
 }
 catch (InvalidOperationException ex) // 捕获 Operator 内部处理的计算错误
 {
  Console.WriteLine($"计算过程中发生错误: {ex.Message}");
  Console.WriteLine();
 }
 catch (FormatException) // 捕获用户输入非数字的错误
 {
  Console.WriteLine("输入格式错误，请输入有效的数字。");
  Console.WriteLine();
 }
 catch (OverflowException) // 捕获数字过大或过小的错误
 {
  Console.WriteLine("输入的数字过大或过小。");
  Console.WriteLine();
 }
 catch (Exception ex) // 捕获其他未知错误
 {
  Console.WriteLine($"发生未知错误: {ex.Message}");
  Console.WriteLine();
 }
}
